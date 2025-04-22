namespace StudentHousingAccomodation.Domain.Dtos.LandLordInformationDtos
{
    public class CreateNewLandLordInformationDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? ProfilePictureUrl { get; set; } // URL to the profile picture
        public Guid UserId { get; set; } // Foreign key property
    }
}