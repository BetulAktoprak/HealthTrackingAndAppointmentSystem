using FluentValidation;
using HealthTrackingApp.Entity.Models;

namespace HealthTrackingApp.Business.Validators;

public class MedicalTestValidator : AbstractValidator<MedicalTest>
{
    public MedicalTestValidator()
    {
    }
}
