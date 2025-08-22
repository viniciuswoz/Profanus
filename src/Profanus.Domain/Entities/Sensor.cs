namespace Profanus.Domain.Entities;

public enum SensorStatus
{
    Unknown = 0,
    Online = 1,
    Offline = 2
}

public class Sensor
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public SensorStatus Status { get; set; }
    public DateTime LastReading { get; set; }
    public Guid? DispositivoId { get; set; }
    public Dispositivo? Dispositivo { get; set; }
}
