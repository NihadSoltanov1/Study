using Code8.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code8.Domain.Entities
{
    public class Education : BaseAuditableEntity
    {
        public string? UniversityName { get; set; }
        public string? Speciality { get; set; }
        public string? CurrentGradeLevel { get; set; }
        public float? GPA { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
