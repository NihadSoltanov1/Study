using Code8.Application.Features.Command.Admin.Register;
using MediatR;

namespace Code8.Application.Features.Command.AppUser.Register;

public record UserRegisterCommandRequest : IRequest<UserRegisterCommandResponse>
{
    public string Username { get; set; }
    public string Password { get; set; }
}
