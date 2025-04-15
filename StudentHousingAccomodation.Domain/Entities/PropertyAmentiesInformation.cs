namespace StudentHousingAccomodation.Domain.Entities
{
    public class PropertyAmentiesInformation
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? AmentiesName { get; set; } //e.g. "High-speed internet", "Free parking", "24/7 access"
        public Guid PropertyInformationId { get; set; } //Foreign key property
    }
}