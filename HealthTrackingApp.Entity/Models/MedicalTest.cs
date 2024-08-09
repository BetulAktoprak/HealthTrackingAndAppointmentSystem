using HealthTrackingApp.Entity.Abstractions;

namespace HealthTrackingApp.Entity.Models;

public class MedicalTest : BaseEntity
{
    public Guid PatientId { get; set; }
    public Guid PrescriptionId { get; set; }
    public string? TestName { get; set; }
    public DateTime? TestDate { get; set; }
    public string? Result { get; set; }
    public string? Notes { get; set; }

    public virtual Patient? Patient { get; set; }
    public virtual Prescription? Prescription { get; set; }
}
