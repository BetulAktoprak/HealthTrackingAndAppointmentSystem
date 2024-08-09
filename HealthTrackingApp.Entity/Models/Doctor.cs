using HealthTrackingApp.Entity.Abstractions;

namespace HealthTrackingApp.Entity.Models;

public class Doctor : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? FullName { get; set; }
    public string? Specialty { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    public ICollection<Appointment>? Appointments { get; set; }
    public ICollection<Prescription>? Prescriptions { get; set; }
    public ICollection<TreatmentPlan>? TreatmentPlans { get; set; }

}
