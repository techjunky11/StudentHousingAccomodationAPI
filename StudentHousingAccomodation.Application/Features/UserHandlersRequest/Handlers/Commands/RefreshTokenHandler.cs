using MediatR;
using StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Commands;
using StudentHousingAccomodation.Domain.Records;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

namespace StudentHousingAccomodation.Application.Features.UserHandlersRequest.Handlers.Commands
{
    public class RefreshTokenHandler : IRequestHandler<RefreshTokenRequest, LoginResponse>
    {
        private readonly IUserAccountRepository _userAccountRepository;

        public RefreshTokenHandler(IUserAccountRepository userAccountRepository)
        {
            _userAccountRepository = userAccountRepository;
        }

        public Task<LoginResponse> Handle(RefreshTokenRequest request, CancellationToken cancellationToken)
        {
            return _userAccountRepository.RefreshToken(request.Token, request.RefreshToken);
        }
    }
}