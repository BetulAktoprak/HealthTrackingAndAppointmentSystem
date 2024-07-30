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
    public class AppointmentService : IService<Appointment>
    {
        private readonly AppointmentRepository _appointmentRepository;

        public AppointmentService(AppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public void Add(Appointment entity)
        {
            AppointmentValidator aVal = new();
            ValidationResult result = aVal.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }
            _appointmentRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            var appointmentId = _appointmentRepository.GetByID(id);
            if (appointmentId != null)
            {
                _appointmentRepository.Delete(id);
            }
        }

        public IEnumerable<Appointment>? GetAll()
        {
            return _appointmentRepository.GetAll();
        }

        public Appointment? GetByID(Guid id)
        {
            return _appointmentRepository.GetByID(id);
        }

        public void Update(Appointment entity)
        {
            AppointmentValidator aVal = new();
            ValidationResult result = aVal.Validate(entity);
            if (result.IsValid)
            {
                _appointmentRepository.Update(entity);
            }
        }
    }
}
