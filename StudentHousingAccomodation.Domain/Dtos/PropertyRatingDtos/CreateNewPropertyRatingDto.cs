namespace StudentHousingAccomodation.Domain.Dtos.PropertyRatingDtos
{
    public class CreateNewPropertyRatingDto
    {
        public int Rating { get; set; } // 1 to 5
        public string? Comment { get; set; }
        public Guid PropertyInformationId { get; set; }
        public Guid StudentInformationId { get; set; }
    }
}