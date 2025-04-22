using MediatR;
using StudentHousingAccomodation.Domain.Dtos.UserDtos;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Commands
{
    public class UpdateUserRequest : IRequest<GeneralResponse>
    {
        public UpdateUserDto UpdateUserDto { get; set; }
        public Guid UserId { get; set; } // ID of the user to be updated
    }
}