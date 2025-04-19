using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHousingAccomodation.Application.Features.RoleHandlersRequest.Handlers.Queries;
using StudentHousingAccomodation.Application.Features.RoleHandlersRequest.Requests.Command;
using StudentHousingAccomodation.Application.Features.RoleHandlersRequest.Requests.Queries;

namespace StudentHousingAccomodation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IMediator mediator;

        public RolesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("GetAllRoles")]
        public async Task<IActionResult> GetAllRoles()
        {
            var result = await mediator.Send(new GetAllRolesNameRequest());
            return Ok(result);
        }

        [HttpPost("CreateRole")]
        public async Task<IActionResult> CreateRole(string Name)
        {
            var result = await mediator.Send(new CreateNewRoleRequest { RoleName = Name });
            return Ok(result);
        }
    }
}