using Microsoft.EntityFrameworkCore;
using HealthTrackingApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthTrackingApp.DataAccess.ConfigurationModelBuilder;

namespace HealthTrackingApp.DataAccess.Context
{
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
}
