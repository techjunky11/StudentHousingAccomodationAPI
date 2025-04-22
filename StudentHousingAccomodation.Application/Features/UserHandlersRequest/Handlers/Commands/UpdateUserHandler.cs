using AutoMapper;
using MediatR;
using StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Commands;
using StudentHousingAccomodation.Domain.Records;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

namespace StudentHousingAccomodation.Application.Features.UserHandlersRequest.Handlers.Commands
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserRequest, GeneralResponse>
    {
        private readonly IUserAccountRepository _userRepository;
        private readonly IMapper _mapper;

        public UpdateUserHandler(IUserAccountRepository userAccountRepository, IMapper mapper)
        {
            _userRepository = userAccountRepository;
            _mapper = mapper;
        }

        public async Task<GeneralResponse> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
        {
            var user = _userRepository.Get(request.UserId);
            if (user == null) return new GeneralResponse(false, "User not found");
            var userToUpdate = _mapper.Map(request.UpdateUserDto, user);
            return await _userRepository.Update(userToUpdate);
        }
    }
}