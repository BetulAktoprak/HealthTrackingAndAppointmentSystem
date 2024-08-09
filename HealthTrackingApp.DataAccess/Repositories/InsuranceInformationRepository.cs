using HealthTrackingApp.DataAccess.Context;
using HealthTrackingApp.Entity.Models;

namespace HealthTrackingApp.DataAccess.Repositories;

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
