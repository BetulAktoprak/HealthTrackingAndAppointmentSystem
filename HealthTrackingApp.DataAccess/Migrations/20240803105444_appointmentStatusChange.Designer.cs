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
    [Migration("20240803105444_appointmentStatusChange")]
    partial class appointmentStatusChange
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
                            Id = new Guid("7d462c25-fdad-41ba-833e-79b4b57d043e"),
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
                            Id = new Guid("5cc936a6-a629-4740-a4b1-3b01a798d376"),
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
                            Id = new Guid("08709540-c8d0-4e88-9b7d-cd0ae75be504"),
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
                            Id = new Guid("85433f1c-b966-420d-a61c-8e714f39c2fd"),
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
                            Id = new Guid("dba7660f-65e8-4d29-ac41-4003f0978ea0"),
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
                            Id = new Guid("3ceca3a8-c508-4a5b-9df9-0c23cbbde174"),
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
                            Id = new Guid("295620bf-63be-4d7a-8aa5-910077a50811"),
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
                            Id = new Guid("3e64b615-6280-40d1-bba7-722eba30af61"),
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
                            Id = new Guid("4eaa5a87-3a12-4450-8c8e-451e354942eb"),
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
                            Id = new Guid("4b092e1e-ddd7-4c02-b89d-ab0a1efb800d"),
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

                    b.Property<string>("Medication")
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
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthTrackingApp.Entity.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("HealthTrackingApp.Entity.Models.InsuranceInformation", b =>
                {
                    b.HasOne("HealthTrackingApp.Entity.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("HealthTrackingApp.Entity.Models.Invoice", b =>
                {
                    b.HasOne("HealthTrackingApp.Entity.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("HealthTrackingApp.Entity.Models.MedicalTest", b =>
                {
                    b.HasOne("HealthTrackingApp.Entity.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("HealthTrackingApp.Entity.Models.Prescription", b =>
                {
                    b.HasOne("HealthTrackingApp.Entity.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthTrackingApp.Entity.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("HealthTrackingApp.Entity.Models.TreatmentPlan", b =>
                {
                    b.HasOne("HealthTrackingApp.Entity.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthTrackingApp.Entity.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}
