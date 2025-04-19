using StudentHousingAccomodation.Domain.Entities;

namespace StudentHousingAccomodation.Domain.Dtos.UserDtos
{
    public class GetUserDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string UserName { get; set; } //e.g. "JohnDoe"
        public string Password { get; set; } //e.g. "password123"
        public string Email { get; set; }
        public string PhoneNumber { get; set; } //e.g. "+1234567890"
        public string? ProfilePictureUrl { get; set; } // URL to the profile picture
        public string? Address { get; set; } //e.g. "123 Main St, City, Country"
        public DateTime DateCreated { get; set; } //e.g. "2023-10-01"
        public DateTime DateModified { get; set; } //e.g. "2023-10-01"
        public bool IsVerified { get; set; } // true or false
        public string? RoleName { get; set; } // Role of the user (e.g. "Admin", "Student", "Landlord")
        public DateTime? LastLoginDate { get; set; } //e.g. "2023-10-01"
        public DateTime? LastPasswordChangeDate { get; set; } //e.g. "2023-10-01"
    }
}