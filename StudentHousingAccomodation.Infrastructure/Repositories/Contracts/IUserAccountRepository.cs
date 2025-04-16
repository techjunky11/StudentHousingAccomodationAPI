using StudentHousingAccomodation.Domain.Dtos.UserDtos;
using StudentHousingAccomodation.Domain.Entities;
using StudentHousingAccomodation.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Contracts
{
    public interface IUserAccountRepository : IGenericRepository<User>
    {
        public Task<User> GetUserByEmail(string email);

        public Task<List<User>> GetUsersByRoleId(Guid roleId);

        public Task<LoginResponse> LoginToAccount(Login user);

        public Task<LoginResponse> RefreshToken(string token, string refreshToken);
    }
}