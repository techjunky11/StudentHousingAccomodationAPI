namespace StudentHousingAccomodation.Domain.Dtos.PropertyRatingDtos
{
    public class UpdateThePropertyRatingDto
    {
        public int Rating { get; set; } // 1 to 5
        public string? Comment { get; set; }
    }
}