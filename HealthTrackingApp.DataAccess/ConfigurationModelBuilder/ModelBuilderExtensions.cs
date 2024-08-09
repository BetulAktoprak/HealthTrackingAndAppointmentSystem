using HealthTrackingApp.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthTrackingApp.DataAccess.ConfigurationModelBuilder;

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
        var doctor7 = Guid.NewGuid();
        var doctor8 = Guid.NewGuid();
        var doctor9 = Guid.NewGuid();
        var doctor10 = Guid.NewGuid();

        modelBuilder.Entity<Doctor>().HasData(
            new Doctor()
            {
                Id = doctor1,
                FirstName = "Ahmet",
                LastName = "Akgül",
                FullName = "Ahmet Akgül",
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
                FullName = "Aybars Akkor",
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
                FullName = "Neslihan Şenocak",
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
                FullName = "Mustafa Şener",
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
                FullName = "Alparslan Baksu",
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
                FullName = "Serdar Saraç",
                Specialty = "Fizik Tedavi ve Rehabilitasyon",
                Email = "serdar@gmail.com",
                Phone = "5555555555",
                Address = "İstanbul"
            },
            new Doctor()
            {
                Id = doctor7,
                FirstName = "Metin",
                LastName = "Güler",
                FullName = "Metin Güler",
                Specialty = "Beyin ve Sinir Cerrahisi",
                Email = "metin@gmail.com",
                Phone = "5555555555",
                Address = "İstanbul"
            },
            new Doctor()
            {
                Id = doctor8,
                FirstName = "Bahadır",
                LastName = "Baykal",
                FullName = "Bahadır Baykal",
                Specialty = "Kulak, Burun, Boğaz - KBB",
                Email = "bahadır@gmail.com",
                Phone = "5555555555",
                Address = "İstanbul"
            },
            new Doctor()
            {
                Id = doctor9,
                FirstName = "Ahmet",
                LastName = "Altıntaş",
                FullName = "Ahmet Altıntaş",
                Specialty = "Kulak, Burun, Boğaz - KBB",
                Email = "ahmet@gmail.com",
                Phone = "5555555555",
                Address = "İstanbul"
            },
            new Doctor()
            {
                Id = doctor10,
                FirstName = "Haydar",
                LastName = "Yalman",
                FullName = "Haydar Yalman",
                Specialty = "Genel Cerrahi",
                Email = "haydar@gmail.com",
                Phone = "5555555555",
                Address = "İstanbul"
            });
    }
}
