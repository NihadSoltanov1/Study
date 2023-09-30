using Amazon.Runtime.Internal;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code8.Application.Features.Command.Applicants.ApplyCourse
{
    public class ApplyCourseCommandRequest : IRequest<ApplyCourseCommandResponse>
    {
        public string? Name { get; set; }
        public string? DeviceId { get; set; }
    }

}
