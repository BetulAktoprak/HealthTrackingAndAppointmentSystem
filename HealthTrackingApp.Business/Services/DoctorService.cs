using FluentValidation;
using FluentValidation.Results;
using HealthTrackingApp.Business.Abstractions;
using HealthTrackingApp.Business.Validators;
using HealthTrackingApp.DataAccess.Repositories;
using HealthTrackingApp.Entity.Models;

namespace HealthTrackingApp.Business.Services;

public class DoctorService : IService<Doctor>
{
    private readonly DoctorRepository _doctorRepository;

    public DoctorService(DoctorRepository doctorRepository)
    {
        _doctorRepository = doctorRepository;
    }

    public void Add(Doctor entity)
    {
        DoctorValidator dVal = new();
        ValidationResult result = dVal.Validate(entity);
        if (!result.IsValid)
        {
            throw new ValidationException(string.Join("\n", result.Errors.Select(e => e.ErrorMessage)));
        }
        _doctorRepository.Add(entity);
    }

    public void Delete(Guid id)
    {
        var doctorId = _doctorRepository.GetByID(id);
        if (doctorId != null)
        {
            _doctorRepository.Delete(id);
        }
    }

    public IEnumerable<Doctor>? GetAll()
    {
        return _doctorRepository.GetAll();
    }

    public Doctor? GetByID(Guid id)
    {
        return _doctorRepository.GetByID(id);
    }

    public void Update(Doctor entity)
    {
        DoctorValidator dVal = new();
        ValidationResult result = dVal.Validate(entity);
        if (result.IsValid)
        {
            _doctorRepository.Update(entity);
        }
        else
        {
            throw new ValidationException(string.Join("\n", result.Errors.Select(e => e.ErrorMessage)));
        }
    }
    public List<string> GetAllUniqueSpecialties()
    {
        return _doctorRepository.GetAllUniqueSpecialties();
    }

    public List<Doctor> GetDoctorsBySpecialty(string specialty)
    {
        return _doctorRepository.GetDoctorsBySpecialty(specialty);
    }

}
