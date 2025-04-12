namespace StudentHousingAccomodation.Domain.Entities
{
    public class RoomAmentiesInformation
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? AmentiesName { get; set; } //e.g. "High-speed internet", "Free parking", "24/7 access"
        public RoomInformation? RoomInformation { get; set; } //Navigation property
        public Guid PropertyInformationId { get; set; } //Foreign key property
    }
}