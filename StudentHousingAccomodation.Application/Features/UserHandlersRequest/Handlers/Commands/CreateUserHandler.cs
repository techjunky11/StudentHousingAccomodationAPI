using AutoMapper;
using MediatR;
using StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Commands;
using StudentHousingAccomodation.Domain.Entities;
using StudentHousingAccomodation.Domain.Records;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

namespace StudentHousingAccomodation.Application.Features.UserHandlersRequest.Handlers.Commands
{
    public class CreateUserHandler : IRequestHandler<CreateUserRequest, GeneralResponse>
    {
        private readonly IUserAccountRepository _userRepository;
        private readonly IMapper _mapper;

        public CreateUserHandler(IUserAccountRepository userAccountRepository, IMapper mapper)
        {
            _userRepository = userAccountRepository;

            _mapper = mapper;
        }

        public Task<GeneralResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request.CreateNewUserDto);
            return _userRepository.Add(user);
        }
    }
}