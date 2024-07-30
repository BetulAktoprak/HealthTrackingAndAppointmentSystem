using HealthTrackingApp.Entity.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTrackingApp.Entity.Models
{
    public class MedicalTest : BaseEntity
    {
        public Guid PatientId { get; set; }
        public string? TestName { get; set; }
        public DateTime? TestDate { get; set; }
        public string? Result { get; set; }
        public string? Notes { get; set; }

        public virtual Patient? Patient { get; set; }
    }

}
