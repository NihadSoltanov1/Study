using Chatverse.Application.Common.Interfaces;
using MediatR;

namespace Code8.Application.Features.Command.User.LoginUserByDeviceId
{
    public class LoginUserByDeviceIdCommandHandler : IRequestHandler<LoginUserByDeviceIdCommandRequest, LoginUserByDeviceIdCommandResponse>
    {
        private readonly IApplicationDbContext _context;

        public LoginUserByDeviceIdCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<LoginUserByDeviceIdCommandResponse> Handle(LoginUserByDeviceIdCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.User newUser = new Domain.Entities.User()
            {
                DeviceId = request.DeviceId
            };
            _context.Users.Add(newUser);
           await _context.SaveChangesAsync(cancellationToken);

            return new LoginUserByDeviceIdCommandResponse();
        }
    }
}
