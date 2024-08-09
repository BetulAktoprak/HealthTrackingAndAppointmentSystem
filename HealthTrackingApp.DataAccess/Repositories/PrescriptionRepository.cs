using HealthTrackingApp.DataAccess.Context;
using HealthTrackingApp.Entity.Models;

namespace HealthTrackingApp.DataAccess.Repositories;

public class PrescriptionRepository : GenericRepository<Prescription>
{
    public PrescriptionRepository(ApplicationDbContext context) : base(context)
    {
    }
}
