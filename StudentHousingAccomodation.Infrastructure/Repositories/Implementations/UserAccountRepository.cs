using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using StudentHousingAccomodation.Data.Data;
using StudentHousingAccomodation.Domain.Dtos.UserDtos;
using StudentHousingAccomodation.Domain.Entities;
using StudentHousingAccomodation.Domain.Records;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Implementations
{
    public class UserAccountRepository : GenericRepository<User>, IUserAccountRepository
    {
        private readonly IUserAccountRepository userAccountRepository;
        private readonly IUserRolesRepository userRolesRepository;
        private readonly IOptions<JwtSection> config;

        private readonly AppDbContext db;

        public UserAccountRepository(IOptions<JwtSection> config, AppDbContext _db, IUserRolesRepository userRolesRepository, IUserAccountRepository userAccountRepository) : base(_db)
        {
            this.userRolesRepository = userRolesRepository;
            db = _db;
            this.userAccountRepository = userAccountRepository;
            this.config = config;
        }

        public override async Task<GeneralResponse> Add(User user)
        {
            //If user model is empty
            if (user == null)
            {
                return new GeneralResponse(false, "Model Empty");
            }

            //Find the user
            var checkUser = await userAccountRepository.GetUserByEmail(user.Email!);
            //user is found
            if (checkUser != null)
            {
                return new GeneralResponse(false, "User registered already");
            }

            var checkRole = userRolesRepository.Get(user.UserRolesId);
            if (checkRole == null)
            {
                return new GeneralResponse(false, "User Role not found");
            }
            //if user is not found we add to database
            var appUser = await AddToDatabase(new User()
            {
                //add Register models to map to the ApplicationUser model
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Address = user.Address,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                IsVerified = false,
                LoginAttempts = 0,
                IsLocked = false,
                LastLoginDate = null,
                LastPasswordChangeDate = null,
                //map the user roles to the user roles class
                UserRolesId = user.UserRolesId,
                Password = BCrypt.Net.BCrypt.HashPassword(user.Password) //encrypt password to database
            });

            return new GeneralResponse(true, "Account Created!");
        }

        public Task<User> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetUsersByRoleId(Guid roleId)
        {
            throw new NotImplementedException();
        }

        public async Task<LoginResponse> LoginToAccount(Login user)
        {
            if (user == null) return new LoginResponse(false, "Model is empty");

            //find the Application user using emailaddress
            var appUser = await GetUserByEmail(user.EmailAddress!);
            if (appUser == null) return new LoginResponse(false, "User NotFound");

            //verify the 2 password by using our encryption class
            if (!BCrypt.Net.BCrypt.Verify(user.Password, appUser.Password))
                return new LoginResponse(false, "Email/Password not valid");
            //we get the user role from system roles of the appuser.id
            var getUserRole = await userRolesRepository.GetUserRoleByUserIdAsync(appUser.Id);
            if (getUserRole == null) return new LoginResponse(false, "User role not found");

            string jwtToken = GenerateToken(appUser, getUserRole.RoleName!);
            string refreshToken = GenerateRefreshToken();
            //save the refresh token to the database
            var finduser = await db.RefreshTokens.FirstOrDefaultAsync(_ => _.UserId == appUser.Id);

            if (finduser != null)
            {
                finduser!.Token = refreshToken;
                await db.SaveChangesAsync();
            }
            else
            {
                await AddToDatabase(new RefreshTokens()
                {
                    Token = refreshToken,
                    UserId = appUser.Id
                });
            }

            return new LoginResponse(true, "Login succcessfully", jwtToken, refreshToken);
        }

        public async Task<LoginResponse> RefreshToken(string token, string refreshToken)
        {
            if (token is null)
            {
                return new LoginResponse(false, "Model is empty");
            }
            // find the token from the database from refreshtokens class and match with token provided
            var findToken = await db.RefreshTokens.FirstOrDefaultAsync(_ => _.Token!.Equals(token));
            if (findToken is null) return new LoginResponse(false, "Refresh token is required");

            //get user details from the token user id
            var user = await db.Users.FirstOrDefaultAsync(_ => _.Id == findToken.UserId);
            if (user is null) return new LoginResponse(false, "refresh token could not be generated because user not found");
            var userRole = await userRolesRepository.GetUserRoleByUserIdAsync(user.Id);
            string jwtToken = GenerateToken(user, userRole.RoleName!);
            string newrefreshToken = GenerateRefreshToken();
            var updateRefreshToken = await db.RefreshTokens.FirstOrDefaultAsync(_ => _.UserId == user.Id);
            if (updateRefreshToken is null) return new LoginResponse(false, "RefreshToken could not be generated because User Has not Signed In");

            updateRefreshToken.Token = newrefreshToken;
            await db.SaveChangesAsync();
            return new LoginResponse(true, "Token refreshed successfully", jwtToken, newrefreshToken);
        }

        private string GenerateToken(User user, string role)
        {
            var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.Value.Key!));
            var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);
            var userClaims = new[]
            {
                //create a new list of list
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                new Claim(ClaimTypes.Name,user.UserName),
                new Claim(ClaimTypes.Email,user.Email!),
                new Claim(ClaimTypes.Role,role!)
            };
            var token = new JwtSecurityToken(
                issuer: config.Value.Issuer,
                audience: config.Value.Audience,
                claims: userClaims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials
                );
            //return the string token
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private string GenerateRefreshToken() => Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));

        private async Task<T> AddToDatabase<T>(T model)
        {
            var result = db.Add(model);
            await db.SaveChangesAsync();
            return (T)result.Entity;
        }
    }
}