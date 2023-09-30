using Amazon.Runtime.Internal;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code8.Application.Features.Command.User.LoginUserByDeviceId
{
    public class LoginUserByDeviceIdCommandRequest : IRequest<LoginUserByDeviceIdCommandResponse>
    {
        public string? DeviceId { get; set; }
    }
}
