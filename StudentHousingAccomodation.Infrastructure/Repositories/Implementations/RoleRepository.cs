using StudentHousingAccomodation.Data.Data;
using StudentHousingAccomodation.Domain.Entities;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Implementations
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        private readonly AppDbContext db;

        public RoleRepository(AppDbContext _db) : base(_db)
        {
            db = _db;
        }

        public async Task<Role> GetRoleByName(string roleName)
        {
            var role = db.Roles!.FirstOrDefault(x => x.Name!.ToLower() == roleName.ToLower());
            return role!;
        }

        public async Task<List<string>> GetRoleListName()
        {
            var roleList = db.Roles!.Select(x => x.Name).ToList();
            return roleList!;
        }
    }
}