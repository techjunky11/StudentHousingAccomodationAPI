using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHousingAccomodation.Application.Features.RoleHandlersRequest.Requests.Command;
using StudentHousingAccomodation.Application.Features.RoleHandlersRequest.Requests.Queries;
using StudentHousingAccomodation.Domain.Entities;
using StudentHousingAccomodation.Domain.Records;

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
        public async Task<IReadOnlyList<Role>> GetAllRoles()
        {
            return await mediator.Send(new GetAllRolesNameRequest());
        }

        [HttpPost("CreateRole")]
        public async Task<GeneralResponse> CreateRole(string Name)
        {
            return await mediator.Send(new CreateNewRoleRequest { RoleName = Name });
        }
    }
}