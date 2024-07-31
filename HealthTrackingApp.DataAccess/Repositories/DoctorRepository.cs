using HealthTrackingApp.DataAccess.Context;
using HealthTrackingApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTrackingApp.DataAccess.Repositories
{
    public class DoctorRepository : GenericRepository<Doctor>
    {
        private readonly ApplicationDbContext _context;
        public DoctorRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public List<string> GetAllUniqueSpecialties()
        {
            return _context.Doctors.Select(d => d.Specialty).Distinct().ToList();
        }
        public List<Doctor> GetDoctorsBySpecialty(string specialty)
        {
            return _context.Doctors.Where(d => d.Specialty == specialty).ToList();
        }
    }
}
