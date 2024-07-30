using HealthTrackingApp.DataAccess.Context;
using HealthTrackingApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTrackingApp.DataAccess.Repositories
{
    public class InsuranceInformationRepository : GenericRepository<InsuranceInformation>
    {
        private readonly ApplicationDbContext _context;
        public InsuranceInformationRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public InsuranceInformation GetByPatientId(Guid patientId)
        {
            return _context.InsuranceInformations.FirstOrDefault(i => i.PatientId == patientId);
        }
    }
}
