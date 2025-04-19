using MediatR;
using StudentHousingAccomodation.Application.Features.RoleHandlersRequest.Requests.Queries;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

namespace StudentHousingAccomodation.Application.Features.RoleHandlersRequest.Handlers.Queries
{
    public class GetAllRolesNameHandler : IRequestHandler<GetAllRolesNameRequest, List<string>>
    {
        private readonly IRoleRepository _roleRepository;

        public GetAllRolesNameHandler(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public Task<List<string>> Handle(GetAllRolesNameRequest request, CancellationToken cancellationToken)
        {
            return _roleRepository.GetRoleListName();
        }
    }
}