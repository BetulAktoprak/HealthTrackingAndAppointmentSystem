using HealthTrackingApp.Entity.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTrackingApp.Entity.Models
{
    public class Patient : BaseEntity
    {
        public string SSN { get; set; }  
        public string? FullName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Gender { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? MedicalHistory { get; set; }
        public string? MaritalStatus { get; set; }
        public string? EmergencyContactPerson { get; set; }
        public string? EmergencyContactNumber { get; set; }
        public string? BloodType { get; set; }
        public string? Allergies { get; set; }
        public string? ChronicDiseases { get; set; }
        public string? Medications { get; set; }
        public ICollection<Appointment>? Appointments { get; set; }
        public ICollection<InsuranceInformation>? InsuranceInformations { get; set; }
        public ICollection<Invoice>? Invoices { get; set; }
        public ICollection<MedicalTest>? MedicalTests { get; set; }
        public ICollection<Prescription>? Prescriptions { get; set; }
        public ICollection<TreatmentPlan>? TreatmentPlans { get; set; }
    }

}
