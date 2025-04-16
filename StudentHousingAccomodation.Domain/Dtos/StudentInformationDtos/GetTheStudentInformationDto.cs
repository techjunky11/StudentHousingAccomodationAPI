using StudentHousingAccomodation.Domain.Dtos.PropertyInformationDtos;
using StudentHousingAccomodation.Domain.Dtos.PropertyRatingDtos;
using StudentHousingAccomodation.Domain.Dtos.RoomInformationDto;
using StudentHousingAccomodation.Domain.Dtos.StudentInterestsDtos;
using StudentHousingAccomodation.Domain.Entities;

namespace StudentHousingAccomodation.Domain.Dtos.StudentInformationDtos
{
    public class GetTheStudentInformationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? UniversityName { get; set; } // Name of the university
        public string? CourseName { get; set; } // Name of the course
        public string? StudentId { get; set; } // Unique student ID
        public string? ProfilePictureUrl { get; set; } // URL to the profile picture
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public User? User { get; set; } // Role of the user (e.g. "Admin", "Student", "Landlord")
        public List<GetTheStudentInterestsDto>? StudentInterestsDto { get; set; } // List of interests
        public List<GetThePropertyInformationDto>? PropertyInformationDto { get; set; } // List of properties the student is interested in
        public List<GetTheRoomInformationDto>? RoomInformationDto { get; set; } // List of rooms the student is interested in
        public List<GetThePropertyRatingDto>? PropertyRatingsDto { get; set; }
    }
}