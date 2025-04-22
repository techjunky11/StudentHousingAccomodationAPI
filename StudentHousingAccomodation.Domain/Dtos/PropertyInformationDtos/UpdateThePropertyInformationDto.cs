namespace StudentHousingAccomodation.Domain.Dtos.PropertyInformationDtos
{
    public class UpdateThePropertyInformationDto
    {
        public UpdateThePropertyInformationDto()
        {
            DateModified = DateTime.Now;
        }

        public string PropertyName { get; set; }
        public string PropertyDescription { get; set; }
        public decimal PropertyMonthlyRent { get; set; }
        public string IsAvailable { get; set; }
        public DateTime DateModified { get; set; }
        public string TitleDeedsOrBillUrl { get; set; }
        public string PropertyAddress { get; set; }
        public decimal? PropertyLatitudeCoordinates { get; set; }
        public decimal? PropertLongitudeCoordinates { get; set; }
        public string PropertyType { get; set; }
    }
}