using HealthTrackingApp.DataAccess.ConfigurationModelBuilder;
using HealthTrackingApp.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthTrackingApp.DataAccess.Context;

public class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer("Server=BPC24\\MSSQLSERVER02;Database=SaglıkTakipVeRandevu;Integrated Security=True;Trust Server Certificate=True;");
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-GQ3I60J\MSSQLSERVER01;Initial Catalog=HealthTrackingAppDb;Integrated Security=True;TrustServerCertificate=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TreatmentPlan>()
            .HasOne(tp => tp.Prescription)
            .WithMany(p => p.TreatmentPlans)
            .HasForeignKey(tp => tp.PrescriptionId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<MedicalTest>()
            .HasOne(mt => mt.Prescription)
            .WithMany(p => p.MedicalTests)
            .HasForeignKey(mt => mt.PrescriptionId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.DefinedClasses();
    }

    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<InsuranceInformation> InsuranceInformations { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<MedicalTest> MedicalTests { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<TreatmentPlan> TreatmentPlans { get; set; }
}
