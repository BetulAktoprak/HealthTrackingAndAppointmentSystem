using FluentValidation;
using FluentValidation.Results;
using HealthTrackingApp.Business.Abstractions;
using HealthTrackingApp.Business.Validators;
using HealthTrackingApp.DataAccess.Repositories;
using HealthTrackingApp.Entity.Models;

namespace HealthTrackingApp.Business.Services;

public class InvoiceService : IService<Invoice>
{
    private readonly InvoiceRepository _invoiceRepository;

    public InvoiceService(InvoiceRepository invoiceRepository)
    {
        _invoiceRepository = invoiceRepository;
    }

    public void Add(Invoice entity)
    {
        InvoiceValidator iVal = new();
        ValidationResult result = iVal.Validate(entity);
        if (!result.IsValid)
        {
            throw new ValidationException(string.Join("\n", result.Errors.Select(e => e.ErrorMessage)));
        }
        _invoiceRepository.Add(entity);
    }

    public void Delete(Guid id)
    {
        var invoiceId = _invoiceRepository.GetByID(id);
        if (invoiceId != null)
        {
            _invoiceRepository.Delete(id);
        }
    }

    public IEnumerable<Invoice>? GetAll()
    {
        return _invoiceRepository.GetAll();
    }

    public Invoice? GetByID(Guid id)
    {
        return _invoiceRepository.GetByID(id);
    }

    public void Update(Invoice entity)
    {
        InvoiceValidator iVal = new();
        ValidationResult result = iVal.Validate(entity);
        if (result.IsValid)
        {
            _invoiceRepository.Update(entity);
        }
        else
        {
            throw new ValidationException(string.Join("\n", result.Errors.Select(e => e.ErrorMessage)));
        }
    }
}
