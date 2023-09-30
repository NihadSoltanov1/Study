using Code8.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code8.Domain.Entities
{
    public class User : BaseAuditableEntity
    {
        public string? Name{ get; set; }
        public DateTime? BirthDate{ get; set; }
        public string? Gender{ get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public string?  DeviceId { get; set; }
        public Education? Education { get; set; }
        public ICollection<Interest>? Interests { get; set; }
        public ICollection<Applicant>? Applicants { get; set; }
    }
}
