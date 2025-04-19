using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using StudentHousingAccomodation.Application.Features.UserHandlersRequest.Handlers.Commands;
using StudentHousingAccomodation.Application.Features.UserHandlersRequest.Handlers.Queries;

namespace StudentHousingAccomodation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAccountRepositoryController : ControllerBase
    {
        private readonly IMediator mediator;

        public UserAccountRepositoryController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserHandler command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("Login")]
        public async Task<IActionResult> Login([FromBody] LoginHandler command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("GetUserById")]
        public async Task<IActionResult> GetUserById([FromBody] GetUserHandler command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers([FromBody] GetAllUserHandler command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("DeleteUser")]
        public async Task<IActionResult> DeleteUser([FromBody] DeleteUserHandler command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpPut("UpdateUser")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserHandler command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
    }
}