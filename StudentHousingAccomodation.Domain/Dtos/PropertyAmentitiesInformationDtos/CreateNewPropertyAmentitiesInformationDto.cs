namespace StudentHousingAccomodation.Domain.Dtos.PropertyAmentitiesInformationDtos
{
    public class CreateNewPropertyAmentitiesInformationDto
    {
        public string? AmentiesName { get; set; } //e.g. "High-speed internet", "Free parking", "24/7 access"
        public Guid PropertyInformationId { get; set; } //Foreign key property
    }
}