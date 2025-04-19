using MediatR;

namespace StudentHousingAccomodation.Application.Features.RoleHandlersRequest.Requests.Queries
{
    public class GetAllRolesNameRequest : IRequest<List<string>>
    {
    }
}