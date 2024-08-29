using Newtonsoft.Json;

public class UpgradeState
{
    [JsonProperty("sequence_id")]
    public int? SequenceId { get; set; }

    [JsonProperty("progress")]
    public string? Progress { get; set; }

    [JsonProperty("status")]
    public string? Status { get; set; }

    [JsonProperty("consistency_request")]
    public bool? ConsistencyRequest { get; set; }

    [JsonProperty("dis_state")]
    public int? DisState { get; set; }

    [JsonProperty("err_code")]
    public int? ErrCode { get; set; }

    [JsonProperty("force_upgrade")]
    public bool? ForceUpgrade { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("module")]
    public string? Module { get; set; }

    [JsonProperty("new_version_state")]
    public int? NewVersionState { get; set; }

    [JsonProperty("cur_state_code")]
    public int? CurStateCode { get; set; }

    [JsonProperty("new_ver_list")]
    public List<string>? NewVerList { get; set; }
}

public class Ipcam
{
    [JsonProperty("ipcam_dev")]
    public string? IpcamDev { get; set; }

    [JsonProperty("ipcam_record")]
    public string? IpcamRecord { get; set; }

    [JsonProperty("timelapse")]
    public string? Timelapse { get; set; }

    [JsonProperty("resolution")]
    public string? Resolution { get; set; }

    [JsonProperty("tutk_server")]
    public string? TutkServer { get; set; }

    [JsonProperty("mode_bits")]
    public int? ModeBits { get; set; }
}

public class Upload
{
    [JsonProperty("status")]
    public string? Status { get; set; }

    [JsonProperty("progress")]
    public int? Progress { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }
}

public class Online
{
    [JsonProperty("ahb")]
    public bool? Ahb { get; set; }

    [JsonProperty("rfid")]
    public bool? Rfid { get; set; }

    [JsonProperty("version")]
    public long? Version { get; set; }
}

public class Ams
{
    [JsonProperty("ams")]
    public List<object>? AmsInternal { get; set; }

    [JsonProperty("ams_exist_bits")]
    public string? AmsExistBits { get; set; }

    [JsonProperty("tray_exist_bits")]
    public string? TrayExistBits { get; set; }

    [JsonProperty("tray_is_bbl_bits")]
    public string? TrayIsBblBits { get; set; }

    [JsonProperty("tray_tar")]
    public string? TrayTar { get; set; }

    [JsonProperty("tray_now")]
    public string? TrayNow { get; set; }

    [JsonProperty("tray_pre")]
    public string? TrayPre { get; set; }

    [JsonProperty("tray_read_done_bits")]
    public string? TrayReadDoneBits { get; set; }

    [JsonProperty("tray_reading_bits")]
    public string? TrayReadingBits { get; set; }

    [JsonProperty("version")]
    public int? Version { get; set; }

    [JsonProperty("insert_flag")]
    public bool? InsertFlag { get; set; }

    [JsonProperty("power_on_flag")]
    public bool? PowerOnFlag { get; set; }
}

public class VtTray
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("tag_uid")]
    public string? TagUid { get; set; }

    [JsonProperty("tray_id_name")]
    public string? TrayIdName { get; set; }

    [JsonProperty("tray_info_idx")]
    public string? TrayInfoIdx { get; set; }

    [JsonProperty("tray_type")]
    public string? TrayType { get; set; }

    [JsonProperty("tray_sub_brands")]
    public string? TraySubBrands { get; set; }

    [JsonProperty("tray_color")]
    public string? TrayColor { get; set; }

    [JsonProperty("tray_weight")]
    public string? TrayWeight { get; set; }

    [JsonProperty("tray_diameter")]
    public string? TrayDiameter { get; set; }

    [JsonProperty("tray_temp")]
    public string? TrayTemp { get; set; }

    [JsonProperty("tray_time")]
    public string? TrayTime { get; set; }

    [JsonProperty("bed_temp_type")]
    public string? BedTempType { get; set; }

    [JsonProperty("bed_temp")]
    public string? BedTemp { get; set; }

    [JsonProperty("nozzle_temp_max")]
    public string? NozzleTempMax { get; set; }

    [JsonProperty("nozzle_temp_min")]
    public string? NozzleTempMin { get; set; }

    [JsonProperty("xcam_info")]
    public string? XcamInfo { get; set; }

    [JsonProperty("tray_uuid")]
    public string? TrayUuid { get; set; }

    [JsonProperty("remain")]
    public int? Remain { get; set; }

    [JsonProperty("k")]
    public double? K { get; set; }

    [JsonProperty("n")]
    public int? N { get; set; }

    [JsonProperty("cali_idx")]
    public int? CaliIdx { get; set; }
}

public class LightsReport
{
    [JsonProperty("node")]
    public string? Node { get; set; }

    [JsonProperty("mode")]
    public string? Mode { get; set; }
}

public class Print
{
    [JsonProperty("upgrade_state")]
    public UpgradeState? UpgradeState { get; set; }

    [JsonProperty("ipcam")]
    public Ipcam? Ipcam { get; set; }

    [JsonProperty("upload")]
    public Upload? Upload { get; set; }

    [JsonProperty("nozzle_temper")]
    public double? NozzleTemper { get; set; }

    [JsonProperty("nozzle_target_temper")]
    public double? NozzleTargetTemper { get; set; }

    [JsonProperty("bed_temper")]
    public double? BedTemper { get; set; }

    [JsonProperty("bed_target_temper")]
    public double? BedTargetTemper { get; set; }

    [JsonProperty("chamber_temper")]
    public int? ChamberTemper { get; set; }

    [JsonProperty("mc_print_stage")]
    public string? McPrintStage { get; set; }

    [JsonProperty("heatbreak_fan_speed")]
    public string? HeatbreakFanSpeed { get; set; }

    [JsonProperty("cooling_fan_speed")]
    public string? CoolingFanSpeed { get; set; }

    [JsonProperty("big_fan1_speed")]
    public string? BigFan1Speed { get; set; }

    [JsonProperty("big_fan2_speed")]
    public string? BigFan2Speed { get; set; }

    [JsonProperty("mc_percent")]
    public int? McPercent { get; set; }

    [JsonProperty("mc_remaining_time")]
    public int? McRemainingTime { get; set; }

    [JsonProperty("ams_status")]
    public int? AmsStatus { get; set; }

    [JsonProperty("ams_rfid_status")]
    public int? AmsRfidStatus { get; set; }

    [JsonProperty("hw_switch_state")]
    public int? HwSwitchState { get; set; }

    [JsonProperty("spd_mag")]
    public int? SpdMag { get; set; }

    [JsonProperty("spd_lvl")]
    public int? SpdLvl { get; set; }

    [JsonProperty("print_error")]
    public int? PrintError { get; set; }

    [JsonProperty("lifecycle")]
    public string? Lifecycle { get; set; }

    [JsonProperty("wifi_signal")]
    public string? WifiSignal { get; set; }

    [JsonProperty("gcode_state")]
    public string? GcodeState { get; set; }

    [JsonProperty("gcode_file_prepare_percent")]
    public string? GcodeFilePreparePercent { get; set; }

    [JsonProperty("queue_number")]
    public int? QueueNumber { get; set; }

    [JsonProperty("queue_total")]
    public int? QueueTotal { get; set; }

    [JsonProperty("queue_est")]
    public int? QueueEst { get; set; }

    [JsonProperty("queue_sts")]
    public int? QueueSts { get; set; }

    [JsonProperty("project_id")]
    public string? ProjectId { get; set; }

    [JsonProperty("profile_id")]
    public string? ProfileId { get; set; }

    [JsonProperty("task_id")]
    public string? TaskId { get; set; }

    [JsonProperty("subtask_id")]
    public string? SubtaskId { get; set; }

    [JsonProperty("subtask_name")]
    public string? SubtaskName { get; set; }

    [JsonProperty("gcode_file")] 
    public string? GcodeFile { get; set; }
    
    [JsonProperty("stg")]
    public List<object>? Stg { get; set; }

    [JsonProperty("stg_cur")]
    public int? StgCur { get; set; }

    [JsonProperty("print_type")]
    public string? PrintType { get; set; }

    [JsonProperty("home_flag")]
    public int? HomeFlag { get; set; }

    [JsonProperty("mc_print_line_number")]
    public string? McPrintLineNumber { get; set; }

    [JsonProperty("mc_print_sub_stage")]
    public int? McPrintSubStage { get; set; }

    [JsonProperty("sdcard")]
    public bool? Sdcard { get; set; }

    [JsonProperty("force_upgrade")]
    public bool? ForceUpgrade { get; set; }

    [JsonProperty("mess_production_state")]
    public string? MessProductionState { get; set; }

    [JsonProperty("layer_num")]
    public int? LayerNum { get; set; }

    [JsonProperty("total_layer_num")]
    public int? TotalLayerNum { get; set; }

    [JsonProperty("s_obj")]
    public List<object>? SObj { get; set; }

    [JsonProperty("filam_bak")]
    public List<object>? FilamBak { get; set; }

    [JsonProperty("fan_gear")]
    public int? FanGear { get; set; }

    [JsonProperty("nozzle_diameter")]
    public string? NozzleDiameter { get; set; }

    [JsonProperty("nozzle_type")]
    public string? NozzleType { get; set; }

    [JsonProperty("cali_version")]
    public int? CaliVersion { get; set; }

    [JsonProperty("hms")]
    public List<object>? Hms { get; set; }

    [JsonProperty("online")]
    public Online? Online { get; set; }

    [JsonProperty("ams")]
    public Ams? Ams { get; set; }

    [JsonProperty("vt_tray")]
    public VtTray? VtTray { get; set; }

    [JsonProperty("lights_report")]
    public List<LightsReport>? LightsReport { get; set; }

    [JsonProperty("command")]
    public string? Command { get; set; }

    [JsonProperty("msg")]
    public int? Msg { get; set; }

    [JsonProperty("sequence_id")]
    public string? SequenceId { get; set; }
}

public class Root
{
    [JsonProperty("print")]
    public Print? Print { get; set; }
}