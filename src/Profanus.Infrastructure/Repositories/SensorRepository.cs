using Microsoft.EntityFrameworkCore;
using Profanus.Application.Interfaces;
using Profanus.Domain.Entities;

namespace Profanus.Infrastructure.Repositories;

public class SensorRepository : ISensorRepository
{
    private readonly ProfanusDbContext _context;

    public SensorRepository(ProfanusDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Sensor>> GetSensorsAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Sensors.AsNoTracking().ToListAsync(cancellationToken);
    }
}
