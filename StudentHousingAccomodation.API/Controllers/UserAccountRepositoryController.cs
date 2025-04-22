using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Commands;
using StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Queries;
using StudentHousingAccomodation.Domain.Dtos.UserDtos;
using StudentHousingAccomodation.Domain.Records;

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
        public async Task<GeneralResponse> CreateUser([FromBody] CreateNewUserDto command)
        {
            return await mediator.Send(new CreateUserRequest { CreateNewUserDto = command });
        }

        [HttpPost("Login")]
        public async Task<LoginResponse> Login(Login command)
        {
            return await mediator.Send(new LoginRequest { user = command });
        }

        [HttpGet("GetUserById")]
        public async Task<GetUserDto> GetUserById(Guid Userid)
        {
            return await mediator.Send(new GetUserRequest { UserId = Userid });
        }

        [HttpGet("GetAllUsers")]
        public async Task<List<GetUserDto>> GetAllUsers()
        {
            return await mediator.Send(new GetAllUserRequest());
        }

        [HttpDelete("DeleteUser")]
        public async Task<GeneralResponse> DeleteUser(Guid UserId)
        {
            return await mediator.Send(new DeleteUserRequest { userId = UserId });
        }

        [HttpPut("UpdateUser")]
        public async Task<GeneralResponse> UpdateUser(Guid UserId, UpdateUserDto userDto)
        {
            return await mediator.Send(new UpdateUserRequest { UserId = UserId, UpdateUserDto = userDto });
        }
    }
}