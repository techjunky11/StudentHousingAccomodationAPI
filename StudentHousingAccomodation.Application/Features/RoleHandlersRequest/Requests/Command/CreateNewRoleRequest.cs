using MediatR;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.RoleHandlersRequest.Requests.Command
{
    public class CreateNewRoleRequest : IRequest<GeneralResponse>
    {
        public string RoleName { get; set; }
    }
}