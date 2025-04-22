using MediatR;
using StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Commands;
using StudentHousingAccomodation.Domain.Records;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

namespace StudentHousingAccomodation.Application.Features.UserHandlersRequest.Handlers.Commands
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserRequest, GeneralResponse>
    {
        private readonly IUserAccountRepository? _userAccountRepository;

        public DeleteUserHandler(IUserAccountRepository userAccountRepository)
        {
            _userAccountRepository = userAccountRepository;
        }

        public Task<GeneralResponse> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
        {
            return _userAccountRepository!.Delete(request.userId);
        }
    }
}