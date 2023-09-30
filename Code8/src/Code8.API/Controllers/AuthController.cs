using Code8.Application.Features.Command.User.LoginUserByDeviceId;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Code8.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("{deviceId}")]
        public async Task<IActionResult> Register([FromRoute] string deviceId)
        {
            LoginUserByDeviceIdCommandRequest loginUserByDeviceId = new LoginUserByDeviceIdCommandRequest();
            loginUserByDeviceId.DeviceId = deviceId;
            var reponse = await _mediator.Send(loginUserByDeviceId);
            return Ok(reponse);
        }
    }
}
