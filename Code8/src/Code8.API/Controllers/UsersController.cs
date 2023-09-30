using Code8.Application.Features.Query.User.GetAllUser;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Code8.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            GetAllUserQueryRequest getAllUserQueryRequest = new GetAllUserQueryRequest();
            var response = await _mediator.Send(getAllUserQueryRequest);
            return Ok(response.AllUsers);
        }
    }
}
