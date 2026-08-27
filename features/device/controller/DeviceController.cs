using Microsoft.AspNetCore.Mvc;

namespace warehouse_telemetry.Features.Device.Controller;


[ApiController]
[Route("api/devices")]
public class DeviceController : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello from Device API");
    }
}
