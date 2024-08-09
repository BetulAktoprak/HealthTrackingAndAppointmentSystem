using FluentValidation;
using FluentValidation.Results;
using HealthTrackingApp.Business.Abstractions;
using HealthTrackingApp.Business.Validators;
using HealthTrackingApp.DataAccess.Repositories;
using HealthTrackingApp.Entity.Models;

namespace HealthTrackingApp.Business.Services;

public class InsuranceInformationService : IService<InsuranceInformation>
{
    private readonly InsuranceInformationRepository _insuranceInformationRepository;

    public InsuranceInformationService(InsuranceInformationRepository ınsuranceInformationRepository)
    {
        _insuranceInformationRepository = ınsuranceInformationRepository;
    }

    public void Add(InsuranceInformation entity)
    {
        InsuranceInformationValidator iVal = new();
        ValidationResult result = iVal.Validate(entity);
        if (!result.IsValid)
        {
            throw new ValidationException(string.Join("\n", result.Errors.Select(e => e.ErrorMessage)));
        }
        _insuranceInformationRepository.Add(entity);
    }

    public void Delete(Guid id)
    {
        var insuranceId = _insuranceInformationRepository.GetByID(id);
        if (insuranceId != null)
        {
            _insuranceInformationRepository.Delete(id);
        }
    }

    public IEnumerable<InsuranceInformation>? GetAll()
    {
        return _insuranceInformationRepository.GetAll();
    }

    public InsuranceInformation? GetByID(Guid id)
    {
        return _insuranceInformationRepository.GetByID(id);
    }

    public void Update(InsuranceInformation entity)
    {
        InsuranceInformationValidator iVal = new();
        ValidationResult result = iVal.Validate(entity);
        if (result.IsValid)
        {
            var existingInsurance = _insuranceInformationRepository.GetByID(entity.Id);
            if (existingInsurance != null)
            {
                existingInsurance.InsuranceType = entity.InsuranceType;
                existingInsurance.InsuranceCompany = entity.InsuranceCompany;
                existingInsurance.PolicyNumber = entity.PolicyNumber;

                _insuranceInformationRepository.Update(existingInsurance);
            }
            else
            {
                throw new ValidationException(string.Join("\n", result.Errors.Select(e => e.ErrorMessage)));
            }
        }
    }

    public InsuranceInformation GetByPatientId(Guid patientId)
    {
        return _insuranceInformationRepository.GetByPatientId(patientId);
    }
}
