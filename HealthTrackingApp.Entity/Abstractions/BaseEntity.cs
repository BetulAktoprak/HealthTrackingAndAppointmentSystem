namespace HealthTrackingApp.Entity.Abstractions;

public class BaseEntity
{
    protected BaseEntity()
    {
        Guid Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
}
