using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using StudentHousingAccomodation.Application.Features.UserHandlersRequest.Handlers.Commands;
using StudentHousingAccomodation.Application.Features.UserHandlersRequest.Handlers.Queries;
using StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Commands;
using StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Queries;
using StudentHousingAccomodation.Domain.Dtos.UserDtos;

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
        public async Task<IActionResult> CreateUser([FromBody] CreateNewUserDto command)
        {
            var result = await mediator.Send(new CreateUserRequest { CreateNewUserDto = command });
            return Ok(result);
        }

        [HttpGet("Login")]
        public async Task<IActionResult> Login([FromBody] Login command)
        {
            var result = await mediator.Send(new LoginRequest { user = command });
            return Ok(result);
        }

        [HttpGet("GetUserById")]
        public async Task<IActionResult> GetUserById(Guid Userid)
        {
            var result = await mediator.Send(new GetUserRequest { UserId = Userid });
            return Ok(result);
        }

        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = await mediator.Send(new GetAllUserRequest());
            return Ok(result);
        }

        [HttpDelete("DeleteUser")]
        public async Task<IActionResult> DeleteUser(Guid UserId)
        {
            var result = await mediator.Send(new DeleteUserRequest { userId = UserId });
            return Ok(result);
        }

        [HttpPut("UpdateUser")]
        public async Task<IActionResult> UpdateUser(Guid UserId, UpdateUserDto userDto)
        {
            var result = await mediator.Send(new UpdateUserRequest { UserId = UserId, UpdateUserDto = userDto });
            return Ok(result);
        }
    }
}