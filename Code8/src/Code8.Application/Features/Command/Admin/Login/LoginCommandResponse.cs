using Code8.Application.DTOs.Token;

namespace Code8.Application.Features.Command.AppUser.Login;

public record LoginCommandResponse
{
    public TokenDto Token { get; set; }
}
