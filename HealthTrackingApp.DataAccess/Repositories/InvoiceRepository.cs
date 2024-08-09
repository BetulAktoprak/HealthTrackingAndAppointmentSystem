using HealthTrackingApp.DataAccess.Context;
using HealthTrackingApp.Entity.Models;

namespace HealthTrackingApp.DataAccess.Repositories;

public class InvoiceRepository : GenericRepository<Invoice>
{
    public InvoiceRepository(ApplicationDbContext context) : base(context)
    {
    }
}
