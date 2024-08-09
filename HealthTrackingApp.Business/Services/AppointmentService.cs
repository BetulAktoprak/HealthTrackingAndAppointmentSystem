using FluentValidation;
using FluentValidation.Results;
using HealthTrackingApp.Business.Abstractions;
using HealthTrackingApp.Business.Validators;
using HealthTrackingApp.DataAccess.Repositories;
using HealthTrackingApp.Entity.Models;

namespace HealthTrackingApp.Business.Services;

public class AppointmentService : IService<Appointment>
{
    private readonly AppointmentRepository _appointmentRepository;

    public AppointmentService(AppointmentRepository appointmentRepository)
    {
        _appointmentRepository = appointmentRepository;
    }

    public void Add(Appointment entity)
    {
        AppointmentValidator aVal = new();
        ValidationResult result = aVal.Validate(entity);
        if (!result.IsValid)
        {
            throw new ValidationException(string.Join("\n", result.Errors.Select(e => e.ErrorMessage)));
        }
        _appointmentRepository.Add(entity);
    }

    public void Delete(Guid id)
    {
        var appointmentId = _appointmentRepository.GetByID(id);
        if (appointmentId != null)
        {
            _appointmentRepository.Delete(id);
        }
    }

    public IEnumerable<Appointment>? GetAll()
    {
        return _appointmentRepository.GetAll();
    }

    public Appointment? GetByID(Guid id)
    {
        return _appointmentRepository.GetByID(id);
    }

    public void Update(Appointment entity)
    {
        AppointmentValidator aVal = new();
        ValidationResult result = aVal.Validate(entity);
        if (result.IsValid)
        {
            _appointmentRepository.Update(entity);
        }
        else
        {
            throw new ValidationException(string.Join("\n", result.Errors.Select(e => e.ErrorMessage)));
        }
    }
}
