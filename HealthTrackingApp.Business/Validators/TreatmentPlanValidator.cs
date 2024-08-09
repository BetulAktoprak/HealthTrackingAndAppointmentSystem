using FluentValidation;
using HealthTrackingApp.Entity.Models;

namespace HealthTrackingApp.Business.Validators;

public class TreatmentPlanValidator : AbstractValidator<TreatmentPlan>
{
    public TreatmentPlanValidator()
    {
    }
}
