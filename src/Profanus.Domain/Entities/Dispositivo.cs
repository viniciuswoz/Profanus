namespace Profanus.Domain.Entities;

public class Dispositivo
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string IpAddress { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public ICollection<Sensor> Sensors { get; set; } = new List<Sensor>();
}
