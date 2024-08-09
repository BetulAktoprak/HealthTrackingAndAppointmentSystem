﻿// <auto-generated />
using HealthTrackingApp.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

#nullable disable

namespace HealthTrackingApp.DataAccess.Migrations;

[DbContext(typeof(ApplicationDbContext))]
partial class ApplicationDbContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "8.0.7")
            .HasAnnotation("Relational:MaxIdentifierLength", 128);

        SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

        modelBuilder.Entity("HealthTrackingApp.Entity.Models.Appointment", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime?>("AppointmentDate")
                    .HasColumnType("datetime2");

                b.Property<TimeSpan?>("AppointmentTime")
                    .HasColumnType("time");

                b.Property<Guid>("DoctorId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Notes")
                    .HasColumnType("nvarchar(max)");

                b.Property<Guid>("PatientId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("SSN")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("Status")
                    .HasColumnType("bit");

                b.HasKey("Id");

                b.HasIndex("DoctorId");

                b.HasIndex("PatientId");

                b.ToTable("Appointments");
            });

        modelBuilder.Entity("HealthTrackingApp.Entity.Models.Doctor", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Address")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Email")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("FirstName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("FullName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("LastName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Phone")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Specialty")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Doctors");

                b.HasData(
                    new
                    {
                        Id = new Guid("94b2c722-1920-4da3-ae33-71ed11ac220f"),
                        Address = "İstanbul",
                        Email = "ahmet@gmail.com",
                        FirstName = "Ahmet",
                        FullName = "Ahmet Akgül",
                        LastName = "Akgül",
                        Phone = "5555555555",
                        Specialty = "Kalp ve Damar Cerrahisi"
                    },
                    new
                    {
                        Id = new Guid("c7cc2493-97a7-47f2-8139-332d41e222f4"),
                        Address = "İstanbul",
                        Email = "aybars@gmail.com",
                        FirstName = "Aybars",
                        FullName = "Aybars Akkor",
                        LastName = "Akkor",
                        Phone = "5555555555",
                        Specialty = "Beyin ve Sinir Cerrahisi"
                    },
                    new
                    {
                        Id = new Guid("40b27d66-ef48-4194-8c86-08b338593b68"),
                        Address = "İstanbul",
                        Email = "neslihan@gmail.com",
                        FirstName = "Neslihan",
                        FullName = "Neslihan Şenocak",
                        LastName = "Şenocak",
                        Phone = "5555555555",
                        Specialty = "Kulak, Burun, Boğaz - KBB"
                    },
                    new
                    {
                        Id = new Guid("72490b01-c3b9-4ab3-965c-aa9998de1a08"),
                        Address = "İstanbul",
                        Email = "mustafa@gmail.com",
                        FirstName = "Mustafa",
                        FullName = "Mustafa Şener",
                        LastName = "Şener",
                        Phone = "5555555555",
                        Specialty = "Genel Cerrahi"
                    },
                    new
                    {
                        Id = new Guid("0d08127c-2725-4883-afea-9526c11db2dc"),
                        Address = "İstanbul",
                        Email = "alparslan@gmail.com",
                        FirstName = "Alparslan",
                        FullName = "Alparslan Baksu",
                        LastName = "Baksu",
                        Phone = "5555555555",
                        Specialty = "Kadın Hastalıkları ve Doğum - Jinekoloji"
                    },
                    new
                    {
                        Id = new Guid("7dbfed67-70a3-4e6f-8387-486ba0e3441c"),
                        Address = "İstanbul",
                        Email = "serdar@gmail.com",
                        FirstName = "Serdar",
                        FullName = "Serdar Saraç",
                        LastName = "Saraç",
                        Phone = "5555555555",
                        Specialty = "Fizik Tedavi ve Rehabilitasyon"
                    },
                    new
                    {
                        Id = new Guid("9cd55cd5-045e-439c-95b0-52ddb6150cd7"),
                        Address = "İstanbul",
                        Email = "metin@gmail.com",
                        FirstName = "Metin",
                        FullName = "Metin Güler",
                        LastName = "Güler",
                        Phone = "5555555555",
                        Specialty = "Beyin ve Sinir Cerrahisi"
                    },
                    new
                    {
                        Id = new Guid("5aafb01b-f64e-4121-9159-03e4e7d04373"),
                        Address = "İstanbul",
                        Email = "bahadır@gmail.com",
                        FirstName = "Bahadır",
                        FullName = "Bahadır Baykal",
                        LastName = "Baykal",
                        Phone = "5555555555",
                        Specialty = "Kulak, Burun, Boğaz - KBB"
                    },
                    new
                    {
                        Id = new Guid("ee2f6ff5-a4cb-442c-9781-492de4aef870"),
                        Address = "İstanbul",
                        Email = "ahmet@gmail.com",
                        FirstName = "Ahmet",
                        FullName = "Ahmet Altıntaş",
                        LastName = "Altıntaş",
                        Phone = "5555555555",
                        Specialty = "Kulak, Burun, Boğaz - KBB"
                    },
                    new
                    {
                        Id = new Guid("63a107ae-b765-4a32-bde8-ccafa77f887b"),
                        Address = "İstanbul",
                        Email = "haydar@gmail.com",
                        FirstName = "Haydar",
                        FullName = "Haydar Yalman",
                        LastName = "Yalman",
                        Phone = "5555555555",
                        Specialty = "Genel Cerrahi"
                    });
            });

        modelBuilder.Entity("HealthTrackingApp.Entity.Models.InsuranceInformation", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("CoverageDetails")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("InsuranceCompany")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("InsuranceType")
                    .HasColumnType("nvarchar(max)");

                b.Property<Guid>("PatientId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("PolicyNumber")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("PatientId");

                b.ToTable("InsuranceInformations");
            });

        modelBuilder.Entity("HealthTrackingApp.Entity.Models.Invoice", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<decimal?>("Amount")
                    .HasColumnType("decimal(18,2)");

                b.Property<DateTime?>("InvoiceDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Notes")
                    .HasColumnType("nvarchar(max)");

                b.Property<Guid>("PatientId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Status")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("PatientId");

                b.ToTable("Invoices");
            });

        modelBuilder.Entity("HealthTrackingApp.Entity.Models.MedicalTest", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Notes")
                    .HasColumnType("nvarchar(max)");

                b.Property<Guid>("PatientId")
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("PrescriptionId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Result")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("TestDate")
                    .HasColumnType("datetime2");

                b.Property<string>("TestName")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("PatientId");

                b.HasIndex("PrescriptionId");

                b.ToTable("MedicalTests");
            });

        modelBuilder.Entity("HealthTrackingApp.Entity.Models.Patient", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Address")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Allergies")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("BirthDate")
                    .HasColumnType("datetime2");

                b.Property<string>("BloodType")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ChronicDiseases")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Email")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("EmergencyContactNumber")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("EmergencyContactPerson")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("FullName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Gender")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("MaritalStatus")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("MedicalHistory")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Medications")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Phone")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("SSN")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Patients");
            });

        modelBuilder.Entity("HealthTrackingApp.Entity.Models.Prescription", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("DoctorId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Instructions")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Medications")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<Guid>("PatientId")
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime?>("PrescriptionDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.HasIndex("DoctorId");

                b.HasIndex("PatientId");

                b.ToTable("Prescriptions");
            });

        modelBuilder.Entity("HealthTrackingApp.Entity.Models.TreatmentPlan", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Description")
                    .HasColumnType("nvarchar(max)");

                b.Property<Guid>("DoctorId")
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("PatientId")
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("PrescriptionId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Progress")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("TreatmentEndDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>("TreatmentStartDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.HasIndex("DoctorId");

                b.HasIndex("PatientId");

                b.HasIndex("PrescriptionId");

                b.ToTable("TreatmentPlans");
            });

        modelBuilder.Entity("HealthTrackingApp.Entity.Models.Appointment", b =>
            {
                b.HasOne("HealthTrackingApp.Entity.Models.Doctor", "Doctor")
                    .WithMany("Appointments")
                    .HasForeignKey("DoctorId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("HealthTrackingApp.Entity.Models.Patient", "Patient")
                    .WithMany("Appointments")
                    .HasForeignKey("PatientId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Doctor");

                b.Navigation("Patient");
            });

        modelBuilder.Entity("HealthTrackingApp.Entity.Models.InsuranceInformation", b =>
            {
                b.HasOne("HealthTrackingApp.Entity.Models.Patient", "Patient")
                    .WithMany("InsuranceInformations")
                    .HasForeignKey("PatientId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Patient");
            });

        modelBuilder.Entity("HealthTrackingApp.Entity.Models.Invoice", b =>
            {
                b.HasOne("HealthTrackingApp.Entity.Models.Patient", "Patient")
                    .WithMany("Invoices")
                    .HasForeignKey("PatientId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Patient");
            });

        modelBuilder.Entity("HealthTrackingApp.Entity.Models.MedicalTest", b =>
            {
                b.HasOne("HealthTrackingApp.Entity.Models.Patient", "Patient")
                    .WithMany("MedicalTests")
                    .HasForeignKey("PatientId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("HealthTrackingApp.Entity.Models.Prescription", "Prescription")
                    .WithMany("MedicalTests")
                    .HasForeignKey("PrescriptionId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.Navigation("Patient");

                b.Navigation("Prescription");
            });

        modelBuilder.Entity("HealthTrackingApp.Entity.Models.Prescription", b =>
            {
                b.HasOne("HealthTrackingApp.Entity.Models.Doctor", "Doctor")
                    .WithMany("Prescriptions")
                    .HasForeignKey("DoctorId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("HealthTrackingApp.Entity.Models.Patient", "Patient")
                    .WithMany("Prescriptions")
                    .HasForeignKey("PatientId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Doctor");

                b.Navigation("Patient");
            });

        modelBuilder.Entity("HealthTrackingApp.Entity.Models.TreatmentPlan", b =>
            {
                b.HasOne("HealthTrackingApp.Entity.Models.Doctor", "Doctor")
                    .WithMany("TreatmentPlans")
                    .HasForeignKey("DoctorId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("HealthTrackingApp.Entity.Models.Patient", "Patient")
                    .WithMany("TreatmentPlans")
                    .HasForeignKey("PatientId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("HealthTrackingApp.Entity.Models.Prescription", "Prescription")
                    .WithMany("TreatmentPlans")
                    .HasForeignKey("PrescriptionId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.Navigation("Doctor");

                b.Navigation("Patient");

                b.Navigation("Prescription");
            });

        modelBuilder.Entity("HealthTrackingApp.Entity.Models.Doctor", b =>
            {
                b.Navigation("Appointments");

                b.Navigation("Prescriptions");

                b.Navigation("TreatmentPlans");
            });

        modelBuilder.Entity("HealthTrackingApp.Entity.Models.Patient", b =>
            {
                b.Navigation("Appointments");

                b.Navigation("InsuranceInformations");

                b.Navigation("Invoices");

                b.Navigation("MedicalTests");

                b.Navigation("Prescriptions");

                b.Navigation("TreatmentPlans");
            });

        modelBuilder.Entity("HealthTrackingApp.Entity.Models.Prescription", b =>
            {
                b.Navigation("MedicalTests");

                b.Navigation("TreatmentPlans");
            });
#pragma warning restore 612, 618
    }
}
