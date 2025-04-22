using MediatR;
using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Commands
{
    public class RefreshTokenRequest : IRequest<LoginResponse>
    {
        public string Token { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
    }
}