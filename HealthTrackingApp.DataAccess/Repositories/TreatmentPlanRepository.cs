using HealthTrackingApp.DataAccess.Context;
using HealthTrackingApp.Entity.Models;

namespace HealthTrackingApp.DataAccess.Repositories;

public class TreatmentPlanRepository : GenericRepository<TreatmentPlan>
{
    public TreatmentPlanRepository(ApplicationDbContext context) : base(context)
    {
    }
}
