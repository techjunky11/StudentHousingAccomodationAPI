namespace StudentHousingAccomodation.Domain.Entities
{
    public class RoomRating
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Rating { get; set; } //e.g. 1,2,3,4,5
        public string? Comment { get; set; } //e.g. "This room is great!"
        public DateTime DateCreated { get; set; } //e.g. 2023-01-01
        public DateTime DateModified { get; set; } //e.g. 2023-01-01
        public Guid RoomInformationId { get; set; } //Foreign key property
        public RoomInformation? RoomInformation { get; set; } //Navigation property
        public Guid StudentInformationId { get; set; } //Foreign key property
        public StudentInformation? StudentInformation { get; set; } //Navigation property
    }
}