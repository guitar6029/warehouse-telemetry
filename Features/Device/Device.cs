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

    public void Ship()
    {
        if (Status != DeviceStatus.Received)
        {
            throw new InvalidOperationException("Only received devices can be shipped.");
        }

        Status = DeviceStatus.Shipped;
    }
}
