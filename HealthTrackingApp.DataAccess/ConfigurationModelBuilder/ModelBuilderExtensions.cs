using HealthTrackingApp.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTrackingApp.DataAccess.ConfigurationModelBuilder
{
    public static class ModelBuilderExtensions
    {
        public static void DefinedClasses(this ModelBuilder modelBuilder)
        {

            var doctor1 = Guid.NewGuid();
            var doctor2 = Guid.NewGuid();
            var doctor3 = Guid.NewGuid();
            var doctor4 = Guid.NewGuid();
            var doctor5 = Guid.NewGuid();
            var doctor6 = Guid.NewGuid();

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor()
                {
                    Id = doctor1,
                    FirstName = "Ahmet",
                    LastName = "Akgül",
                    Specialty = "Kalp ve Damar Cerrahisi",
                    Email = "ahmet@gmail.com",
                    Phone = "5555555555",
                    Address = "İstanbul"
                },
                new Doctor()
                {
                    Id = doctor2,
                    FirstName = "Aybars",
                    LastName = "Akkor",
                    Specialty = "Beyin ve Sinir Cerrahisi",
                    Email = "aybars@gmail.com",
                    Phone = "5555555555",
                    Address = "İstanbul"
                },
                new Doctor()
                {
                    Id = doctor3,
                    FirstName = "Neslihan",
                    LastName = "Şenocak",
                    Specialty = "Kulak, Burun, Boğaz - KBB",
                    Email = "neslihan@gmail.com",
                    Phone = "5555555555",
                    Address = "İstanbul"
                },
                new Doctor()
                {
                    Id = doctor4,
                    FirstName = "Mustafa",
                    LastName = "Şener",
                    Specialty = "Genel Cerrahi",
                    Email = "mustafa@gmail.com",
                    Phone = "5555555555",
                    Address = "İstanbul"
                },
                new Doctor()
                {
                    Id = doctor5,
                    FirstName = "Alparslan",
                    LastName = "Baksu",
                    Specialty = "Kadın Hastalıkları ve Doğum - Jinekoloji",
                    Email = "alparslan@gmail.com",
                    Phone = "5555555555",
                    Address = "İstanbul"
                },
                new Doctor()
                {
                    Id = doctor6,
                    FirstName = "Serdar",
                    LastName = "Saraç",
                    Specialty = "Fizik Tedavi ve Rehabilitasyon",
                    Email = "serdar@gmail.com",
                    Phone = "5555555555",
                    Address = "İstanbul"
                });
        }
    }
}
