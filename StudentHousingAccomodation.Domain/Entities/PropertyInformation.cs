namespace StudentHousingAccomodation.Domain.Entities
{
    public class PropertyInformation
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string PropertyName { get; set; }
        public string PropertyDescription { get; set; }
        public decimal PropertyMonthlyRent { get; set; }
        public string IsAvailable { get; set; } //occupied,pending,coming soon or available
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int TotalRoomAvailable { get; set; }
        public double Distance { get; set; } //distance from the university
        public string TitleDeedsOrBillUrl { get; set; }
        public bool PropertyIsApprovedByAdmin { get; set; }
        public string PropertyAddress { get; set; }
        public decimal? PropertyLatitudeCoordinates { get; set; }
        public decimal? PropertLongitudeCoordinates { get; set; }
        public string PropertyType { get; set; }
        public List<PropertyAmentiesInformation>? Amenties { get; set; }
        public List<PropertyImage>? PropertyImages { get; set; }
        public List<PropertyRating>? PropertyRatings { get; set; }
        public List<RoomInformation>? PropertyRooms { get; set; }
        public LandLordInformation? LandLordInformation { get; set; }
        public Guid LandLordInformationId { get; set; }
    }
}