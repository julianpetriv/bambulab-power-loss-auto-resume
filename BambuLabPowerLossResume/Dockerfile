FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["BambuLabPowerLossResume/BambuLabPowerLossResume.csproj", "BambuLabPowerLossResume/"]
RUN dotnet restore "BambuLabPowerLossResume/BambuLabPowerLossResume.csproj"
COPY . .
WORKDIR "/src/BambuLabPowerLossResume"
RUN dotnet build "BambuLabPowerLossResume.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "BambuLabPowerLossResume.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BambuLabPowerLossResume.dll"]
