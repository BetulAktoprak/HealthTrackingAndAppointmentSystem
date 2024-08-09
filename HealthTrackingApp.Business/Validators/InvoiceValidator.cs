using FluentValidation;
using HealthTrackingApp.Entity.Models;

namespace HealthTrackingApp.Business.Validators;

public class InvoiceValidator : AbstractValidator<Invoice>
{
    public InvoiceValidator()
    {
    }
}
