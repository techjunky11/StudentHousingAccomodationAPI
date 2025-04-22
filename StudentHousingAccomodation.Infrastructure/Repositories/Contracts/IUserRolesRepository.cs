using StudentHousingAccomodation.Domain.Entities;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Contracts
{
    public interface IUserRolesRepository : IGenericRepository<UserRoles>
    {
        public Task<UserRoles> GetUserRoleByUserIdAsync(Guid Userid);
    }
}