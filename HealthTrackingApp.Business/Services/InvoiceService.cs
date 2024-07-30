using FluentValidation.Results;
using HealthTrackingApp.Business.Abstractions;
using HealthTrackingApp.Business.Validators;
using HealthTrackingApp.DataAccess.Repositories;
using HealthTrackingApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTrackingApp.Business.Services
{
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
                throw new Exception(string.Join("\n", result.Errors));
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
        }
    }
}
