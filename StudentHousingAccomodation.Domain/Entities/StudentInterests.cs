namespace StudentHousingAccomodation.Domain.Entities
{
    public class StudentInterests
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Interest { get; set; } //e.g. "Sports", "Music", "Art", etc
        public Guid StudentInformationId { get; set; } //Foreign key property
        public StudentInformation? StudentInformation { get; set; } //Navigation property
    }
}