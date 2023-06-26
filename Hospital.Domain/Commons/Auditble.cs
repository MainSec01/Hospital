using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Commons
{
    public abstract class Auditble
    {
        public Guid Id { get; set; }
        public long? UpdatedBy { get; set; }
        public long? DeletedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}
