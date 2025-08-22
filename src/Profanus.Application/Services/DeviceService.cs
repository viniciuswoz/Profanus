using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Profanus.Application.Dtos;
using Profanus.Application.Interfaces;

namespace Profanus.Application.Services;

/// <summary>
/// Simple implementation of <see cref="IDeviceService"/> that returns a static list of devices.
/// Replace this with a real backend integration.
/// </summary>
public class DeviceService : IDeviceService
{
    public Task<IEnumerable<DeviceDto>> GetDevicesAsync(CancellationToken cancellationToken = default)
    {
        var devices = new List<DeviceDto>
        {
            new()
            {
                Name = "Router-01",
                Label = "Core Router",
                SerialNumber = "SN001",
                IP = "192.168.0.1",
                Version = "1.0.0",
                Model = "XR1000",
                OperationalState = "Up",
                ResyncState = "Synced",
                LastUpdate = DateTime.UtcNow.AddMinutes(-5)
            },
            new()
            {
                Name = "Switch-02",
                Label = "Edge Switch",
                SerialNumber = "SN002",
                IP = "192.168.0.2",
                Version = "1.1.0",
                Model = "XS200",
                OperationalState = "Down",
                ResyncState = "Pending",
                LastUpdate = DateTime.UtcNow.AddMinutes(-30)
            },
            new()
            {
                Name = "Firewall-03",
                Label = "Main Firewall",
                SerialNumber = "SN003",
                IP = "192.168.0.3",
                Version = "2.0.0",
                Model = "FW300",
                OperationalState = "Up",
                ResyncState = "Synced",
                LastUpdate = DateTime.UtcNow.AddHours(-1)
            }
        };

        return Task.FromResult<IEnumerable<DeviceDto>>(devices);
    }
}
