using Chatverse.Application.Common.Interfaces;
using MediatR;

namespace Code8.Application.Features.Command.Applicants.ApplyCourse
{
    public class ApplyCourseCommandHandler : IRequestHandler<ApplyCourseCommandRequest, ApplyCourseCommandResponse>
    {
        private readonly IApplicationDbContext _context;

        public ApplyCourseCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ApplyCourseCommandResponse> Handle(ApplyCourseCommandRequest request, CancellationToken cancellationToken)
        {
            if (request.Name is not null)
            {
                Domain.Entities.Applicant newApplication = new Domain.Entities.Applicant()
                {
                    Name = request.Name,
                    Status = "unaccepted",
                    DeviceId = request.DeviceId
                };
                _context.Applicants.Add(newApplication);
               await _context.SaveChangesAsync(cancellationToken);
            }
            return new ApplyCourseCommandResponse();
        }
    }

}
