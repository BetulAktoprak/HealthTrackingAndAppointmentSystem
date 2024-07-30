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
    public class TreatmentPlanService : IService<TreatmentPlan>
    {
        private readonly TreatmentPlanRepository _treatmentPlanRepository;

        public TreatmentPlanService(TreatmentPlanRepository treatmentPlanRepository)
        {
            _treatmentPlanRepository = treatmentPlanRepository;
        }

        public void Add(TreatmentPlan entity)
        {
            TreatmentPlanValidator tVal = new();
            ValidationResult result = tVal.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }
            _treatmentPlanRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            var treatmentPlanId = _treatmentPlanRepository.GetByID(id);
            if (treatmentPlanId != null)
            {
                _treatmentPlanRepository.Delete(id);
            }
        }

        public IEnumerable<TreatmentPlan>? GetAll()
        {
            return _treatmentPlanRepository.GetAll();
        }

        public TreatmentPlan? GetByID(Guid id)
        {
            return _treatmentPlanRepository.GetByID(id);
        }

        public void Update(TreatmentPlan entity)
        {
            TreatmentPlanValidator tVal = new();
            ValidationResult result = tVal.Validate(entity);
            if (result.IsValid)
            {
                _treatmentPlanRepository.Update(entity);
            }
        }
    }
}
