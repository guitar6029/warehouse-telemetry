using Microsoft.EntityFrameworkCore;
using warehouse_telemetry.Features.Device.Service;
using warehouse_telemetry.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDeviceServices();

var connectionString =
    builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapControllers();

app.Run();
