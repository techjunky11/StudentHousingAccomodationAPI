using MediatR;
using StudentHousingAccomodation.Application.Features.RoleHandlersRequest.Requests.Queries;
using StudentHousingAccomodation.Domain.Entities;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

namespace StudentHousingAccomodation.Application.Features.RoleHandlersRequest.Handlers.Queries
{
    public class GetAllRolesNameHandler : IRequestHandler<GetAllRolesNameRequest, IReadOnlyList<Role>>
    {
        private readonly IRoleRepository _roleRepository;

        public GetAllRolesNameHandler(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<IReadOnlyList<Role>> Handle(GetAllRolesNameRequest request, CancellationToken cancellationToken)
        {
            return await _roleRepository.GetAll();
        }
    }
}