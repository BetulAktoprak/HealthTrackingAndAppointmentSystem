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
    [Migration("20240804235121_updateMedication")]
    partial class updateMedication
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
                            Id = new Guid("9993ca88-3c36-46bd-a384-fc2576def601"),
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
                            Id = new Guid("d3f95929-f223-43f0-b811-217c8760b410"),
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
                            Id = new Guid("304846a8-b604-4737-9885-9997d7a9bc20"),
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
                            Id = new Guid("e4bf6304-5f37-4a5b-8543-7fd45bbced5c"),
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
                            Id = new Guid("92aff278-3bb3-49bc-9286-f84d040ed2fb"),
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
                            Id = new Guid("831b941b-f7f3-481e-abe6-a5ef8dfc6c33"),
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
                            Id = new Guid("5948cd45-148e-4830-ba7d-ff9859e31d9c"),
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
                            Id = new Guid("78d759ef-995f-4776-9442-d3d11b5682f6"),
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
                            Id = new Guid("e2fed086-91e0-4343-a610-20a81368adc8"),
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
                            Id = new Guid("b27b42b5-9dcb-45ac-8c43-69430fa053f0"),
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
