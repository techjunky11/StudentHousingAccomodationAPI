using MediatR;
using StudentHousingAccomodation.Domain.Dtos.UserDtos;

namespace StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Queries
{
    public class GetUserRequest : IRequest<GetUserDto>
    {
        public Guid UserId { get; set; }
    }
}