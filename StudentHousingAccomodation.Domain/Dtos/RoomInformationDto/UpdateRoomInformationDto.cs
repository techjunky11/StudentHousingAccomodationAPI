namespace StudentHousingAccomodation.Domain.Dtos.RoomInformationDto
{
    public class UpdateTheRoomInformationDto
    {
        public string RoomDescription { get; set; }
        public decimal RoomMonthlyRent { get; set; }
        public string IsAvailable { get; set; } //occupied,pending,coming soon or available
        public string RoomType { get; set; }
    }
}