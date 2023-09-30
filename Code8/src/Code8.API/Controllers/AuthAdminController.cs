using Code8.Application.Features.Command.Admin.Register;
using Code8.Application.Features.Command.AppUser.Login;
using Code8.Application.Features.Command.AppUser.Register;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Code8.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthAdminController : ControllerBase
    {
        IMediator _mediator;

        public AuthAdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginCommandRequest loginCommandRequest)
        {
            LoginCommandResponse loginUser = await _mediator.Send(loginCommandRequest);
            return Ok(loginUser.Token.AccessToken);
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterCommandRequest loginCommandRequest)
        {
            UserRegisterCommandResponse loginUser = await _mediator.Send(loginCommandRequest);
            return Ok();
        }
    }
}
