using MediatR;
using StudentHousingAccomodation.Application.Features.RoleHandlersRequest.Requests.Command;
using StudentHousingAccomodation.Domain.Entities;
using StudentHousingAccomodation.Domain.Records;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

namespace StudentHousingAccomodation.Application.Features.RoleHandlersRequest.Handlers.Command
{
    public class CreateNewRoleHandler : IRequestHandler<CreateNewRoleRequest, GeneralResponse>
    {
        private readonly IRoleRepository roleRepository;

        public CreateNewRoleHandler(IRoleRepository role)
        {
            roleRepository = role;
        }

        public async Task<GeneralResponse> Handle(CreateNewRoleRequest request, CancellationToken cancellationToken)
        {
            return await roleRepository.Add(new Role
            {
                Name = request.RoleName
            });
        }
    }
}