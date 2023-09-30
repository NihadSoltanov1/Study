using Code8.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code8.Domain.Entities
{
    public class Applicant : BaseAuditableEntity
    {
        public string? Name { get; set; }
        public string? Status { get; set; }
        public string? DeviceId { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
