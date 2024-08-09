using FluentValidation;
using FluentValidation.Results;
using HealthTrackingApp.Business.Abstractions;
using HealthTrackingApp.Business.Validators;
using HealthTrackingApp.DataAccess.Repositories;
using HealthTrackingApp.Entity.Models;

namespace HealthTrackingApp.Business.Services;

public class PatientService : IService<Patient>
{
    private readonly PatientRepository _patientRepository;

    public PatientService(PatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
    }

    public void Add(Patient entity)
    {
        PatientValidator pVal = new();
        ValidationResult result = pVal.Validate(entity);
        if (!result.IsValid)
        {
            throw new ValidationException(string.Join("\n", result.Errors.Select(e => e.ErrorMessage)));
        }
        _patientRepository.Add(entity);
    }

    public void Delete(Guid id)
    {
        var patientId = _patientRepository.GetByID(id);
        if (patientId != null)
        {
            _patientRepository.Delete(id);
        }
    }

    public IEnumerable<Patient>? GetAll()
    {
        return _patientRepository.GetAll();
    }

    public Patient? GetByID(Guid id)
    {
        return _patientRepository.GetByID(id);
    }

    public void Update(Patient entity)
    {
        PatientValidator pVal = new();
        ValidationResult result = pVal.Validate(entity);
        if (result.IsValid)
        {
            _patientRepository.Update(entity);
        }
        else
        {
            throw new ValidationException(string.Join("\n", result.Errors.Select(e => e.ErrorMessage)));
        }
    }
    public Guid GetIdBySsn(string ssn)
    {
        return _patientRepository.GetIdBySsn(ssn);
    }

}
