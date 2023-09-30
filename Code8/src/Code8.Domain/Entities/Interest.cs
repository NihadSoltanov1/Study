using Code8.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code8.Domain.Entities
{
    public class Interest : BaseAuditableEntity
    {
        public string? EnjoySubject { get; set; }
        public string? Hobbies { get; set; }
        public string? CareerEnvision { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
