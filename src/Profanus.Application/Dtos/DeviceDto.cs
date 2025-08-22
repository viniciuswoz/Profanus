using System;

namespace Profanus.Application.Dtos;

/// <summary>
/// Data transfer object representing a network device.
/// </summary>
public class DeviceDto
{
    public string Name { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public string SerialNumber { get; set; } = string.Empty;
    public string IP { get; set; } = string.Empty;
    public string Version { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string OperationalState { get; set; } = string.Empty;
    public string ResyncState { get; set; } = string.Empty;
    public DateTime LastUpdate { get; set; }
}
