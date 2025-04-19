using Microsoft.EntityFrameworkCore;
using StudentHousingAccomodation.Domain.Entities;

namespace StudentHousingAccomodation.Data.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<RoomInformation> RoomInformation { get; set; }
        public DbSet<StudentInformation> StudentInformation { get; set; }
        public DbSet<PropertyInformation> PropertyInformation { get; set; }
        public DbSet<PropertyRating> PropertyRatings { get; set; }
        public DbSet<PropertyImage> PropertyImages { get; set; }
        public DbSet<PropertyAmentiesInformation> PropertyAmentiesInformation { get; set; }
        public DbSet<LandLordInformation> LandLordInformation { get; set; }
        public DbSet<StudentInterests> StudentInterests { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<RefreshTokens>? RefreshTokens { get; set; }
        public DbSet<Role>? Roles { get; set; }
    }
}