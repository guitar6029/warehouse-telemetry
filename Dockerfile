FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

COPY warehouse-telemetry.csproj .

RUN dotnet restore

COPY . .

RUN dotnet tool restore

RUN dotnet publish -c Release -o /app/publish --no-restore


FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime

WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "warehouse-telemetry.dll"]


FROM build AS dev

ENTRYPOINT ["dotnet", "run", "--urls=http://0.0.0.0:5073"]
