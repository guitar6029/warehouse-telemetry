namespace warehouse_telemetry.Features.Device.Service;

public class DeviceService : IDeviceService
{

    public void ShipDevice(Device device)
    {
        if (device.Status != DeviceStatus.Received)
        {
            throw new InvalidOperationException("Only received devices can be shipped.");
        }

        // TODO
        // for now demonstrate the business rule
        device.Ship();
    }

    public void ShipDeviceById(Guid id)
    {
        // check if id exist , throw DeviceNotFoundException
        // if exits then ship it
    }
}
