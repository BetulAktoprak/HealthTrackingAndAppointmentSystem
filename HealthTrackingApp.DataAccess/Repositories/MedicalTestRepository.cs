using HealthTrackingApp.DataAccess.Context;
using HealthTrackingApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTrackingApp.DataAccess.Repositories
{
    public class MedicalTestRepository : GenericRepository<MedicalTest>
    {
        public MedicalTestRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
