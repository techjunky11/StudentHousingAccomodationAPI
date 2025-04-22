using MediatR;
using StudentHousingAccomodation.Domain.Entities;

namespace StudentHousingAccomodation.Application.Features.RoleHandlersRequest.Requests.Queries
{
    public class GetAllRolesNameRequest : IRequest<IReadOnlyList<Role>>
    {
    }
}