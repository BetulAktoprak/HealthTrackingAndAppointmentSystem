using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTrackingApp.Entity.Abstractions
{
    public class BaseEntity
    {
        protected BaseEntity()
        {
           Guid Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
