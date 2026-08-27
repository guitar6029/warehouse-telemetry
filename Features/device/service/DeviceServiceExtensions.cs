namespace warehouse_telemetry.Features.Device.Service;

public static class DeviceServiceExtensions
{
    public static IServiceCollection AddDeviceServices(
        this IServiceCollection services
    )
    {
        services.AddScoped<IDeviceService, DeviceService>();

        return services;
    }
}
