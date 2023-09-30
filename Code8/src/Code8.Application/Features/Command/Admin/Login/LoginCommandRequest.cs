using MediatR;

namespace Code8.Application.Features.Command.AppUser.Login;

public record LoginCommandRequest : IRequest<LoginCommandResponse>
{
    public string? Username { get; set; }
    public string? Password { get; set; }
}
