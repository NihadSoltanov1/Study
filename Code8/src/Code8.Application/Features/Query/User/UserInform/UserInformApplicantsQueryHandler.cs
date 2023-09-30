using Chatverse.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Code8.Application.Features.Query.User.UserInform
{
    public class UserInformApplicantsQueryHandler : IRequestHandler<UserInformApplicantsQueryRequest, UserInformApplicantsQueryResponse>
    {
        private readonly IApplicationDbContext _context;

        public UserInformApplicantsQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<UserInformApplicantsQueryResponse> Handle(UserInformApplicantsQueryRequest request, CancellationToken cancellationToken)
        {
           var user = _context.Users.FirstOrDefault(x => x.DeviceId == request.DeviceId);
            if(user is not null)
            {
                var myapplicants = await _context.Applicants.Where(x => x.UserId == user.Id).ToListAsync();
                List<MyApplicant> myApplicant = new List<MyApplicant>();
                if (myapplicants is not null)
                {
                    foreach (var i in myapplicants)
                    {
                        MyApplicant applicant = new MyApplicant()
                        {
                            Name = i.Name,
                            Status = i.Status
                        };
                        myApplicant.Add(applicant);
                    }
                }
                return new UserInformApplicantsQueryResponse()
                {
                    MyApplicants = myApplicant
                };
            }
            return new UserInformApplicantsQueryResponse();

              
        }
    }
}
