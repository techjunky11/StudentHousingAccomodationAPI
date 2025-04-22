namespace StudentHousingAccomodation.Domain.Dtos.UserDtos
{
    public class CreateNewUserDto
    {
        public string UserName { get; set; } //e.g. "JohnDoe"
        public string Password { get; set; } //e.g. "password123"
        public string Email { get; set; }
        public string PhoneNumber { get; set; } //e.g. "+1234567890"
        public string? Address { get; set; } //e.g. "123 Main St, City, Country"
        public Guid RoleId { get; set; } // Foreign key property
    }
}