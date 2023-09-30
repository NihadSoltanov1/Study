using Code8.Application.Features.Command.Admin.Register;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace Code8.Application.Features.Command.AppUser.Register;

public record UserRegisterCommandHandler : IRequestHandler<UserRegisterCommandRequest, UserRegisterCommandResponse>
{
    private readonly UserManager<Code8.Domain.Identity.Admin> _userManager;
    private readonly IConfiguration _configuration;
    public UserRegisterCommandHandler(UserManager<Code8.Domain.Identity.Admin> userManager, IConfiguration configuration)
    {
        _userManager = userManager;
        _configuration = configuration;
    }

    public async Task<UserRegisterCommandResponse> Handle(UserRegisterCommandRequest request, CancellationToken cancellationToken)
    {

        Code8.Domain.Identity.Admin newUser = new()
        {
            UserName = "keberos"
            
        };

        IdentityResult identityResult = await _userManager.CreateAsync(newUser, request.Password);
        return new UserRegisterCommandResponse();
    }
}
