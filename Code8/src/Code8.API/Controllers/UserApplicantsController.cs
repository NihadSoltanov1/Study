using Code8.Application.Features.Command.Applicants.ApplyCourse;
using Code8.Application.Features.Command.Course.RecommendCourse;
using Code8.Application.Features.Command.User.LoginUserByDeviceId;
using Code8.Application.Features.Query.User.UserInform;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Code8.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserApplicantsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserApplicantsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{deviceId}")]
        public async Task<IActionResult> Applicants([FromRoute] string deviceId)
        {
            UserInformApplicantsQueryRequest  userInform = new UserInformApplicantsQueryRequest();
            userInform.DeviceId = deviceId;
            var reponse = await _mediator.Send(userInform);
            return Ok(reponse.MyApplicants);
        }


        [HttpPost]
        public async Task<IActionResult> JoinCourse(RecommendCourseCommandRequest recommendCourseCommandRequest)
        {
           var response = await _mediator.Send(recommendCourseCommandRequest);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> ApplyCourse(ApplyCourseCommandRequest applyCourseCommandRequest)
        {
            var response = await _mediator.Send(applyCourseCommandRequest);
            return Ok(response);
        }
    }
}
