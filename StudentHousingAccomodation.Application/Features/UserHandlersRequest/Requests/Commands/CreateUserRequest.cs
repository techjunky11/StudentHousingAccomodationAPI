using MediatR;
using StudentHousingAccomodation.Domain.Dtos.UserDtos;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Commands
{
    public class CreateUserRequest : IRequest<GeneralResponse>
    {
        public CreateNewUserDto? CreateNewUserDto { get; set; }
    }
}