using Chatverse.Application.Exceptions;
using Code8.Application.Common.Security.Jwt;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Code8.Application.Features.Command.AppUser.Login;



public class LoginCommandHandler : IRequestHandler<LoginCommandRequest, LoginCommandResponse>
{
    private readonly ITokenHandler _tokenHandler;
    private readonly UserManager<Code8.Domain.Identity.Admin> _userManager;

    public LoginCommandHandler(ITokenHandler tokenHandler, UserManager<Code8.Domain.Identity.Admin> userManager)
    {
        _tokenHandler = tokenHandler;
        _userManager = userManager;
    }

    public async Task<LoginCommandResponse> Handle(LoginCommandRequest request, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByNameAsync(request.Username);
        if (user is null)
        {
            if (user is null) throw new NotFoundException("User not found.");
        }
        var result = await _userManager.CheckPasswordAsync(user, request.Password);
        if (!result) throw new AuthenticationErrorException();
        var accessToken = _tokenHandler.CreateAccessToken(60,user);

        return new LoginCommandResponse()
        {
            Token = accessToken
        };

    }
}
