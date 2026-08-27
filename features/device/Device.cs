namespace warehouse_telemetry.Features.Device;

public class Device
{
    public Guid Id { get; private set; }

    public string Name { get; private set; }

    public string SerialNumber { get; private set; }

    public DeviceStatus Status { get; private set; }

    public Device(string name, string serialNumber, DeviceStatus status)
    {
        Name = name;
        SerialNumber = serialNumber;
        Status = status;
    }
}
