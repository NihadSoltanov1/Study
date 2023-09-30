using Amazon.Runtime.Internal;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code8.Application.Features.Command.Course.RecommendCourse
{
    public class RecommendCourseCommandRequest : IRequest<RecommendCourseCommandResponse>
    {
        public string?  FullName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public string? UniversityName { get; set; } 
        public string? Speciality { get; set; } 
        public string? CurrentGradeLevel { get; set; } 
        public float? GPA { get; set; } 
        public string? EnjoySubject { get; set; }
        public string? Hobbies { get; set; }
        public string? CareerEnvision { get; set; }
    }
}
