using Amazon.Runtime.Internal;
using Chatverse.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code8.Application.Features.Query.User.GetAllUser
{
    public class GetAllUserQueryRequest : IRequest<GetAllUserQueryResponse>
    {
    }



    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQueryRequest, GetAllUserQueryResponse>
    {
        private readonly IApplicationDbContext _context;

        public GetAllUserQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<GetAllUserQueryResponse> Handle(GetAllUserQueryRequest request, CancellationToken cancellationToken)
        {
            var applications = await _context.Applicants.ToListAsync();
            if(applications is not null)
            {
                List<GetAllUser> getAllUsers = new List<GetAllUser>();

                foreach(var i in applications)
                {
                    var user = _context.Users.FirstOrDefault(x => x.Id == i.UserId);
                    GetAllUser users = new GetAllUser()
                    {
                        Name = user.Name,
                        EduName = i.Name,
                        Status = i.Status,
                        Date = i.CreatedDate
                    };
                    getAllUsers.Add(users);
                }
                return new GetAllUserQueryResponse()
                {
                    AllUsers = getAllUsers
                };
            }
            return new GetAllUserQueryResponse();
        }
    }
}
