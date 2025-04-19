using AutoMapper;
using MediatR;
using StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Queries;
using StudentHousingAccomodation.Domain.Dtos.UserDtos;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

namespace StudentHousingAccomodation.Application.Features.UserHandlersRequest.Handlers.Queries
{
    public class GetUserHandler : IRequestHandler<GetUserRequest, GetUserDto>
    {
        private readonly IUserAccountRepository _userRepository;
        private readonly IMapper _mapper;

        public GetUserHandler(IUserAccountRepository userAccountRepository, IMapper mapper)
        {
            _userRepository = userAccountRepository;
            _mapper = mapper;
        }

        public async Task<GetUserDto> Handle(GetUserRequest request, CancellationToken cancellationToken)
        {
            var user = _userRepository.Get(request.UserId);
            return _mapper.Map<GetUserDto>(user);
        }
    }
}