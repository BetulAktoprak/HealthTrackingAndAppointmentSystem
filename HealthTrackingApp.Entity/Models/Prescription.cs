using HealthTrackingApp.Entity.Abstractions;

namespace HealthTrackingApp.Entity.Models;

public class Prescription : BaseEntity
{
    public Guid PatientId { get; set; }
    public Guid DoctorId { get; set; }
    public DateTime? PrescriptionDate { get; set; }
    public string? Instructions { get; set; }

    public virtual Patient? Patient { get; set; }
    public virtual Doctor? Doctor { get; set; }
    public List<string> Medications { get; set; } = new List<string>();
    public ICollection<TreatmentPlan>? TreatmentPlans { get; set; }
    public ICollection<MedicalTest>? MedicalTests { get; set; }

}
