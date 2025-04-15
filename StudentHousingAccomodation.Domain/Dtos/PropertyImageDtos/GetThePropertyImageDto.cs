using StudentHousingAccomodation.Domain.Dtos.PropertyInformationDtos;

namespace StudentHousingAccomodation.Domain.Dtos.PropertyImageDtos
{
    public class GetThePropertyImageDto
    {
        public string ImageUrl { get; set; }
        public string ImageDescription { get; set; }
        public string ImageType { get; set; } //e.g. front view, back view, side view, etc
        public string ImageName { get; set; } //e.g. front view, back view, side view, etc
        public string ImageSize { get; set; } //e.g. 1MB, 2MB, etc
        public string ImageFormat { get; set; } //e.g. jpg, png, etc
        public string ImageResolution { get; set; } //e.g. 1920x1080, 1280x720, etc
        public DateTime ImageUploadDate { get; set; } //e.g. 2023-01-01, 2023-01-02, etc
    }
}