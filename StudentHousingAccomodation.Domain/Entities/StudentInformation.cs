using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Domain.Entities
{
    public class StudentInformation
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? ProfilePictureUrl { get; set; } // URL to the profile picture
        public string? UniversityName { get; set; } // Name of the university
        public string? CourseName { get; set; } // Name of the course
        public string? StudentId { get; set; } // Unique student ID
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsVerified { get; set; } // true or false
        public List<StudentInterests>? StudentInterests { get; set; } // List of interests
        public List<PropertyInformation>? PropertyInformation { get; set; } // List of properties the student is interested in
        public List<RoomInformation>? RoomInformation { get; set; } // List of rooms the student is interested in
        public List<PropertyRating>? PropertyRatings { get; set; }
    }
}