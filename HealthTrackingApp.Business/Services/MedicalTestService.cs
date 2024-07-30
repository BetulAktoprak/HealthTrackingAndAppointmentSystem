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
    public class MedicalTestService : IService<MedicalTest>
    {
        private readonly MedicalTestRepository _medicalTestRepository;

        public MedicalTestService(MedicalTestRepository medicalTestRepository)
        {
            _medicalTestRepository = medicalTestRepository;
        }

        public void Add(MedicalTest entity)
        {
            MedicalTestValidator mVal = new();
            ValidationResult result = mVal.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }
            _medicalTestRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            var medicalId = _medicalTestRepository.GetByID(id);
            if (medicalId != null)
            {
                _medicalTestRepository.Delete(id);
            }
        }

        public IEnumerable<MedicalTest>? GetAll()
        {
            return _medicalTestRepository.GetAll();
        }

        public MedicalTest? GetByID(Guid id)
        {
            return _medicalTestRepository.GetByID(id);
        }

        public void Update(MedicalTest entity)
        {
            MedicalTestValidator mVal = new();
            ValidationResult result = mVal.Validate(entity);
            if (result.IsValid)
            {
                _medicalTestRepository.Update(entity);
            }
        }
    }
}
