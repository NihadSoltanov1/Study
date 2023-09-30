using Chatverse.Application.Common.Interfaces;
using MediatR;

namespace Code8.Application.Features.Command.Course.RecommendCourse
{
    public class RecommendCourseCommandHandler : IRequestHandler<RecommendCourseCommandRequest, RecommendCourseCommandResponse>
    {
        private readonly IApplicationDbContext _context;

        public RecommendCourseCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<RecommendCourseCommandResponse> Handle(RecommendCourseCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.User newUser = new Domain.Entities.User()
            {
                Name = request.FullName,
                BirthDate = request.BirthDate,
                Gender = request.Gender,
                Email = request.Email,
                Password = request.Password,
                AppointmentDate = request.AppointmentDate
            };
            _context.Users.Add(newUser);
           await _context.SaveChangesAsync(cancellationToken);

            Domain.Entities.Education newEducation = new Domain.Entities.Education()
            {
                UniversityName = request.UniversityName,
                Speciality = request.Speciality,
                CurrentGradeLevel = request.CurrentGradeLevel,
                GPA = request.GPA,
                UserId = newUser.Id
            };
            _context.Educations.Add(newEducation);
            await _context.SaveChangesAsync(cancellationToken);

            Domain.Entities.Interest newInters = new Domain.Entities.Interest()
            {
                EnjoySubject = request.EnjoySubject,
                Hobbies = request.Hobbies,
                CareerEnvision = request.CareerEnvision,
                UserId = newUser.Id
            };
            _context.Interests.Add(newInters);
            await _context.SaveChangesAsync(cancellationToken);
            return new RecommendCourseCommandResponse()
            {
                isSuccess = true
            };
        }
    }
}
