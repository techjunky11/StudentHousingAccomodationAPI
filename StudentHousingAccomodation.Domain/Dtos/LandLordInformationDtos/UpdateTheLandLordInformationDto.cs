namespace StudentHousingAccomodation.Domain.Dtos.LandLordInformationDtos
{
    public class UpdateTheLandLordInformationDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? ProfilePictureUrl { get; set; } // URL to the profile picture
    }
}