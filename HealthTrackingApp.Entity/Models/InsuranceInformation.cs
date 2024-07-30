using HealthTrackingApp.Entity.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTrackingApp.Entity.Models
{
    public class InsuranceInformation : BaseEntity
    {
        public Guid PatientId { get; set; }
        public string? InsuranceType { get; set; }
        public string? InsuranceCompany { get; set; }
        public string? PolicyNumber { get; set; }
        public string? CoverageDetails { get; set; }

        public virtual Patient? Patient { get; set; }
    }

}
