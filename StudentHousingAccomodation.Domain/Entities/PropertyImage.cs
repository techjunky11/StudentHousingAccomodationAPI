namespace StudentHousingAccomodation.Domain.Entities
{
    public class PropertyImage
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ImageUrl { get; set; }
        public string ImageDescription { get; set; }
        public string ImageSize { get; set; } //e.g. 1MB, 2MB, etc
        public string ImageFormat { get; set; } //e.g. jpg, png, etc
        public string ImageResolution { get; set; } //e.g. 1920x1080, 1280x720, etc
        public DateTime ImageUploadDate { get; set; } //e.g. 2023-01-01, 2023-01-02, etc

        //Relationships
        public Guid RoomInformationGuidId { get; set; } //e.g
    }
}