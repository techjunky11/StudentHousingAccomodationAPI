using MediatR;
using StudentHousingAccomodation.Domain.Dtos.UserDtos;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Commands
{
    public class LoginRequest : IRequest<LoginResponse>
    {
        public Login? user { get; set; } //e.g. "JohnDoe"
    }
}