using StudentHousingAccomodation.Domain.Entities;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Contracts
{
    public interface IRoleRepository : IGenericRepository<Role>
    {
        public Task<Role> GetRoleByName(string roleName);

        public Task<List<string>> GetRoleListName();
    }
}