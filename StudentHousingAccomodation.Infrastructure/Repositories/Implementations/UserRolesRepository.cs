using Microsoft.EntityFrameworkCore;
using StudentHousingAccomodation.Data.Data;
using StudentHousingAccomodation.Domain.Entities;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Implementations
{
    public class UserRolesRepository : GenericRepository<UserRoles>, IUserRolesRepository
    {
        private readonly AppDbContext db;

        public UserRolesRepository(AppDbContext _db) : base(_db)
        {
            db = _db;
        }

        public async Task<UserRoles> GetUserRoleByUserIdAsync(Guid Userid)
        {
            var userRole = await db.UserRoles
                .Where(x => x.userId == Userid)
                .FirstOrDefaultAsync();
            return userRole!;
        }
    }
}