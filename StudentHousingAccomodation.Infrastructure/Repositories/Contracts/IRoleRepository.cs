using StudentHousingAccomodation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Contracts
{
    public interface IRoleRepository : IGenericRepository<Role>
    {
        public Task<Role> GetRoleByName(string roleName);

        public Task<List<string>> GetRoleListName();
    }
}