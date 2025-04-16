using StudentHousingAccomodation.Data.Data;
using StudentHousingAccomodation.Domain.Entities;
using StudentHousingAccomodation.Domain.Records;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Implementations
{
    public class UserAccountRepository : GenericRepository<User>, IUserAccountRepository
    {
        public UserAccountRepository(AppDbContext _db) : base(_db)
        {
        }

        public Task<User> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetUsersByRoleId(Guid roleId)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponse> LoginToAccount(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponse> RefreshToken(string token, string refreshToken)
        {
            throw new NotImplementedException();
        }
    }
}