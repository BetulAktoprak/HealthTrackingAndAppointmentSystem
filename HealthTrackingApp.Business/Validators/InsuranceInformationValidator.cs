using FluentValidation;
using HealthTrackingApp.Entity.Models;

namespace HealthTrackingApp.Business.Validators;

public class InsuranceInformationValidator : AbstractValidator<InsuranceInformation>
{
    public InsuranceInformationValidator()
    {
    }
}
