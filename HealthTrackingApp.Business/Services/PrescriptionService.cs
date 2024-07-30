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
    public class PrescriptionService : IService<Prescription>
    {
        private readonly PrescriptionRepository _prescriptionRepository;

        public PrescriptionService(PrescriptionRepository prescriptionRepository)
        {
            _prescriptionRepository = prescriptionRepository;
        }

        public void Add(Prescription entity)
        {
            PrescriptionValidator pVal = new();
            ValidationResult result = pVal.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }
            _prescriptionRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            var prescriptionId = _prescriptionRepository.GetByID(id);
            if (prescriptionId != null)
            {
                _prescriptionRepository.Delete(id);
            }
        }

        public IEnumerable<Prescription>? GetAll()
        {
            return _prescriptionRepository.GetAll();
        }

        public Prescription? GetByID(Guid id)
        {
            return _prescriptionRepository.GetByID(id);
        }

        public void Update(Prescription entity)
        {
            PrescriptionValidator pVal = new();
            ValidationResult result = pVal.Validate(entity);
            if (result.IsValid)
            {
                _prescriptionRepository.Update(entity);
            }
        }
    }
}
