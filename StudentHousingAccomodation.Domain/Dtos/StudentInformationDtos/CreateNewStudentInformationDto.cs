using StudentHousingAccomodation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Domain.Dtos.StudentInformationDtos
{
    public class CreateNewStudentInformationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? UniversityName { get; set; } // Name of the university
        public string? CourseName { get; set; } // Name of the course
        public string? ProfilePictureUrl { get; set; } // URL to the profile picture
        public string? StudentId { get; set; } // Unique student ID
        public Guid UserId { get; set; } // Foreign key property
    }
}