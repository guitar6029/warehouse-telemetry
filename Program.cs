using warehouse_telemetry.Features.Device.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDeviceServices();

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapControllers();

app.Run();
