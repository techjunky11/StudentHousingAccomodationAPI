using MediatR;
using StudentHousingAccomodation.Domain.Dtos.UserDtos;

namespace StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Queries
{
    public class GetAllUserRequest : IRequest<List<GetUserDto>>
    {
    }
}