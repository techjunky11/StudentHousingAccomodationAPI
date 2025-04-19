using AutoMapper;
using MediatR;
using StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Queries;
using StudentHousingAccomodation.Domain.Dtos.LandLordInformationDtos;
using StudentHousingAccomodation.Domain.Dtos.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

namespace StudentHousingAccomodation.Application.Features.UserHandlersRequest.Handlers.Queries
{
    public class GetAllUserHandler : IRequestHandler<GetAllUserRequest, List<GetUserDto>>
    {
        private readonly IUserAccountRepository _userRepository;
        private readonly IMapper _mapper;

        public GetAllUserHandler(IUserAccountRepository userAccountRepository, IMapper mapper)
        {
            _userRepository = userAccountRepository;
            _mapper = mapper;
        }

        public async Task<List<GetUserDto>> Handle(GetAllUserRequest request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAll();
            return _mapper.Map<List<GetUserDto>>(users);
        }
    }
}