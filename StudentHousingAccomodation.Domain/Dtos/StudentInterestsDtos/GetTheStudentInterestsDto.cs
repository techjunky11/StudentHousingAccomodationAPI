using StudentHousingAccomodation.Domain.Entities;

namespace StudentHousingAccomodation.Domain.Dtos.StudentInterestsDtos
{
    public class GetTheStudentInterestsDto
    {
        public string Interest { get; set; } //e.g. "Sports", "Music", "Art", etc
        public StudentInformation? StudentInformation { get; set; } //Navigation property
    }
}