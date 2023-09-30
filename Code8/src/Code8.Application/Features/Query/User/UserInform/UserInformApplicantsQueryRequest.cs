using Amazon.Runtime.Internal;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code8.Application.Features.Query.User.UserInform
{
    public class UserInformApplicantsQueryRequest : IRequest<UserInformApplicantsQueryResponse>
    {
        public string? DeviceId { get; set; }
    }
}
