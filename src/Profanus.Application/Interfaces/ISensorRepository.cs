using Profanus.Domain.Entities;

namespace Profanus.Application.Interfaces;

public interface ISensorRepository
{
    Task<IEnumerable<Sensor>> GetSensorsAsync(CancellationToken cancellationToken = default);
}
