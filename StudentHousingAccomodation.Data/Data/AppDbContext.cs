using Microsoft.EntityFrameworkCore;
using StudentHousingAccomodation.Domain.Entities;

namespace StudentHousingAccomodation.Data.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<RoomAmentiesInformation> RoomAmentiesInformation { get; set; } = null!;
        public DbSet<RoomInformation> RoomInformation { get; set; } = null!;
        public DbSet<RoomImage> RoomImages { get; set; } = null!;
        public DbSet<RoomRating> RoomRatings { get; set; } = null!;
        public DbSet<StudentInformation> StudentInformation { get; set; } = null!;
        public DbSet<PropertyInformation> PropertyInformation { get; set; } = null!;
        public DbSet<PropertyRating> PropertyRatings { get; set; } = null!;
        public DbSet<PropertyImage> PropertyImages { get; set; } = null!;
        public DbSet<PropertyAmentiesInformation> PropertyAmentiesInformation { get; set; } = null!;
        public DbSet<LandLordInformation> LandLordInformation { get; set; } = null!;
        public DbSet<StudentInterests> StudentInterests { get; set; } = null!;
        public DbSet<UserRoles> UserRoles { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
    }
}