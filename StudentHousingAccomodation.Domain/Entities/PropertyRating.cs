namespace StudentHousingAccomodation.Domain.Entities
{
    public class PropertyRating
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Rating { get; set; } // 1 to 5
        public string? Comment { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Guid PropertyInformationId { get; set; }
        public PropertyInformation? PropertyInformation { get; set; }
        public Guid StudentInformationId { get; set; }
        public StudentInformation? StudentInformation { get; set; }
    }
}