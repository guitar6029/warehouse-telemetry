using Microsoft.EntityFrameworkCore;
using warehouse_telemetry.Features.Device;
using warehouse_telemetry.Infrastructure.Persistence;

public class DeviceSeeder
{
    private readonly AppDbContext _db;

    public DeviceSeeder(AppDbContext db)
    {
        _db = db;
    }

    public async Task SeedAsync()
    {
        // check if we have any devices
        // dont seed then
        if (await _db.Devices.AnyAsync())
        {
            return;
        }
        // create devices
        var devices = new List<Device>
        {
            new("Scanner 01", "SN-0001", DeviceStatus.Received),
            new("Scanner 02", "SN-0002", DeviceStatus.Received),
            new("Scanner 03", "SN-0003", DeviceStatus.Received),
            new("Scanner 04", "SN-0004", DeviceStatus.Received),
            new("Scanner 05", "SN-0005", DeviceStatus.Received),
            new("Scanner 06", "SN-0006", DeviceStatus.Received),
            new("Scanner 07", "SN-0007", DeviceStatus.Received),
            new("Scanner 08", "SN-0008", DeviceStatus.Received),
            new("Scanner 09", "SN-0009", DeviceStatus.Received),
            new("Scanner 10", "SN-0010", DeviceStatus.Received),
            new("Scanner 11", "SN-0011", DeviceStatus.Received)
        };


        // save devices
        await _db.Devices.AddRangeAsync(devices);
        await _db.SaveChangesAsync();
    }
}
