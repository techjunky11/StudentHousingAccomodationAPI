namespace StudentHousingAccomodation.Domain.Entities
{
    public class UserRoles
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid RoleId { get; set; } //e.g. "Admin", "Student", "Landlord"
        public Guid userId { get; set; } // Foreign key property
    }
}