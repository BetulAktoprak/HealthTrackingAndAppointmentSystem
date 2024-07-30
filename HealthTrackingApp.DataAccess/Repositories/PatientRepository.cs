﻿using HealthTrackingApp.DataAccess.Context;
using HealthTrackingApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTrackingApp.DataAccess.Repositories
{
    public class PatientRepository : GenericRepository<Patient>
    {
        private readonly ApplicationDbContext _context;
        public PatientRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public Guid GetIdBySsn(string ssn)
        {
            var patient = _context.Patients
                .Where(x => x.SSN == ssn)
                .Select(h => h.Id)
                .FirstOrDefault();

            return patient;
        }

    }
}