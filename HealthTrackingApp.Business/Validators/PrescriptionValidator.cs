using FluentValidation;
using HealthTrackingApp.Entity.Models;

namespace HealthTrackingApp.Business.Validators;

public class PrescriptionValidator : AbstractValidator<Prescription>
{
    public PrescriptionValidator()
    {
    }
}
