using HealthTrackingApp.Entity.Abstractions;

namespace HealthTrackingApp.Entity.Models;

public class TreatmentPlan : BaseEntity
{
    public Guid PatientId { get; set; }
    public Guid DoctorId { get; set; }
    public Guid PrescriptionId { get; set; }
    public DateTime? TreatmentStartDate { get; set; }
    public DateTime? TreatmentEndDate { get; set; }
    public string? Description { get; set; }
    public string? Progress { get; set; }

    public virtual Patient? Patient { get; set; }
    public virtual Doctor? Doctor { get; set; }
    public virtual Prescription? Prescription { get; set; }
}
