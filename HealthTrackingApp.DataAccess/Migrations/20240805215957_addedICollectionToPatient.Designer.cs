﻿// <auto-generated />
using System;
using HealthTrackingApp.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HealthTrackingApp.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240805215957_addedICollectionToPatient")]
    partial class addedICollectionToPatient
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("13f6ffee-a613-4e3c-a525-c4be04ef1983"),
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
                            Id = new Guid("ee9b6c0c-a421-4711-9c39-c13cb6d3c1aa"),
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
                            Id = new Guid("a50847be-fdea-4ae9-9634-4b38a7ab7137"),
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
                            Id = new Guid("febc7c30-b8c1-4e45-9675-eb543919a6a0"),
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
                            Id = new Guid("4f5021a4-5d69-4444-a6d9-28f5c104f5a5"),
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
                            Id = new Guid("548d5aaf-ce2a-47c8-817f-28de9ce65509"),
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
                            Id = new Guid("67aaf196-0da8-42b0-9cd5-d9fe487ad604"),
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
                            Id = new Guid("50cd4e36-5d9a-42ee-a5bd-ceef36f72afe"),
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
                            Id = new Guid("09fc2ca1-7db0-41bd-8374-61ae298eba2c"),
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
                            Id = new Guid("8060ad47-fa0e-4cfb-8ffd-1177b180f76f"),
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

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TestDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TestName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

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

                    b.Property<string>("Progress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TreatmentEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("TreatmentStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

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

                    b.Navigation("Patient");
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

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
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
#pragma warning restore 612, 618
        }
    }
}
