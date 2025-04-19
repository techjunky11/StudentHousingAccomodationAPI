using StudentHousingAccomodation.Data.Data;
using StudentHousingAccomodation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Implementations
{
    public class UserRolesRepository : GenericRepository<UserRoles>, IUserRolesRepository
    {
        public UserRolesRepository(AppDbContext _db) : base(_db)
        {
        }

        public Task<UserRoles> GetUserRoleByUserIdAsync(Guid Userid)
        {
            throw new NotImplementedException();
        }
    }
}