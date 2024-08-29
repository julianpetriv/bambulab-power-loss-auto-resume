using System.Reflection;
using Microsoft.Extensions.Configuration;
using MQTTnet;
using MQTTnet.Client;
using Newtonsoft.Json;

const string pushAll = "{\"pushing\": {\"sequence_id\": \"0\", \"command\": \"pushall\"}}";
const string resume = "{\"print\": {\"sequence_id\": \"0\", \"command\": \"resume\"}}";

const string powerLossHexError = "03008007";

var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables()
    .AddUserSecrets(Assembly.GetExecutingAssembly(), true);

var config = builder.Build();

var serialNumber = config["serial"]!;

var host = config["host"]!;
var port = int.Parse(config["port"]!);
var username = config["username"]!;
var token = config["token"]!;

var pushAllMessage = new MqttApplicationMessageBuilder()
    .WithTopic($"device/{serialNumber}/request")
    .WithPayload(pushAll)
    .WithRetainFlag()
    .Build();

var resumeMessage = new MqttApplicationMessageBuilder()
    .WithTopic($"device/{serialNumber}/request")
    .WithPayload(resume)
    .WithRetainFlag()
    .Build();

var mqttFactory = new MqttFactory();

using var mqttClient = mqttFactory.CreateMqttClient();

var mqttClientOptions = new MqttClientOptionsBuilder()
    .WithTcpServer(host, port)
    .WithCredentials(username, token)
    .WithTlsOptions(new MqttClientTlsOptions(){ UseTls = true })
    .Build();

mqttClient.ApplicationMessageReceivedAsync += async e =>
{
    var response = e.ApplicationMessage.ConvertPayloadToString();
    var resultData = JsonConvert.DeserializeObject<Root>(response);
    
    if (resultData?.Print?.PrintError?.ToString("X8") == powerLossHexError)
    {
        await mqttClient.PublishAsync(resumeMessage, CancellationToken.None);
    }
};

await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);
await mqttClient.SubscribeAsync(new MqttTopicFilterBuilder()
    .WithTopic($"device/{serialNumber}/report")
    .Build());

Console.WriteLine("MQTT client subscribed to topic.");

var timer = new PeriodicTimer(TimeSpan.FromSeconds(10));
while (await timer.WaitForNextTickAsync())
{
    await mqttClient.PublishAsync(pushAllMessage, CancellationToken.None);
}

// Probably will never be called
await mqttClient.DisconnectAsync(new MqttClientDisconnectOptionsBuilder().WithReason(MqttClientDisconnectOptionsReason.NormalDisconnection).Build());