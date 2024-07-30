using HealthTrackingApp.Entity.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTrackingApp.Entity.Models
{
    public class Invoice : BaseEntity
    {
        public Guid PatientId { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? Status { get; set; }
        public string? Notes { get; set; }
        public virtual Patient? Patient { get; set; }
    }

}
