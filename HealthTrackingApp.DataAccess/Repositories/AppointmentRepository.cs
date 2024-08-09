using HealthTrackingApp.DataAccess.Context;
using HealthTrackingApp.Entity.Models;

namespace HealthTrackingApp.DataAccess.Repositories;

public class AppointmentRepository : GenericRepository<Appointment>
{
    public AppointmentRepository(ApplicationDbContext context) : base(context)
    {
    }
}
