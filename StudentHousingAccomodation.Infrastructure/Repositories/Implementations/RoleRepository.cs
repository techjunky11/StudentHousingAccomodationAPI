using StudentHousingAccomodation.Data.Data;
using StudentHousingAccomodation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Implementations
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        private readonly AppDbContext db;

        public RoleRepository(AppDbContext _db) : base(_db)
        {
            db = _db;
        }

        public Task<Role> GetRoleByName(string roleName)
        {
            throw new NotImplementedException();
        }

        public async Task<List<string>> GetRoleListName()
        {
            var roleList =  await db.Roles!.Select(x => x.Name).ToListAsync();
            return roleList!;
        }
    }
}