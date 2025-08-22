using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Profanus.Application.Dtos;

namespace Profanus.Application.Interfaces;

/// <summary>
/// Service abstraction responsible for retrieving devices from a data source.
/// </summary>
public interface IDeviceService
{
    Task<IEnumerable<DeviceDto>> GetDevicesAsync(CancellationToken cancellationToken = default);
}
