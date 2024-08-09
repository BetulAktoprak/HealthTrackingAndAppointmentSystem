using HealthTrackingApp.DataAccess.Context;
using HealthTrackingApp.Entity.Models;

namespace HealthTrackingApp.DataAccess.Repositories;

public class MedicalTestRepository : GenericRepository<MedicalTest>
{
    public MedicalTestRepository(ApplicationDbContext context) : base(context)
    {
    }
}
