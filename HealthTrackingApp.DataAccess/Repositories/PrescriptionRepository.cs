using HealthTrackingApp.DataAccess.Context;
using HealthTrackingApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTrackingApp.DataAccess.Repositories
{
    public class PrescriptionRepository : GenericRepository<Prescription>
    {
        public PrescriptionRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
