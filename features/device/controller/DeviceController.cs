using Microsoft.AspNetCore.Mvc;
using warehouse_telemetry.Features.Device.Service;

namespace warehouse_telemetry.Features.Device.Controller;


[ApiController]
[Route("api/devices")]
public class DeviceController : ControllerBase
{

    private readonly IDeviceService _deviceService;

    public DeviceController(IDeviceService deviceService)
    {
        _deviceService = deviceService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello from Device API");
    }

    [HttpPost("{id}/ship")]
    public IActionResult Ship(Guid id)
    {
        _deviceService.ShipDeviceById(id);

        return Ok("Device shipped");
    }
}
