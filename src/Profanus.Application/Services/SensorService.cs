using Profanus.Application.Interfaces;
using Profanus.Domain.Entities;

namespace Profanus.Application.Services;

public class SensorService
{
    private readonly ISensorRepository _repository;

    public SensorService(ISensorRepository repository)
    {
        _repository = repository;
    }

    public Task<IEnumerable<Sensor>> GetSensorsAsync(CancellationToken cancellationToken = default)
        => _repository.GetSensorsAsync(cancellationToken);
}
