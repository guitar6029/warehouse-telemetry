namespace warehouse_telemetry.Features.Device.Dto;

public record DeviceResponse(Guid Id, string Name, string SerialNumber, DeviceStatus Status);
