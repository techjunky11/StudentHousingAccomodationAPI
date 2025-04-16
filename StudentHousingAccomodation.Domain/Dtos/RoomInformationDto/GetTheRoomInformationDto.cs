using StudentHousingAccomodation.Domain.Dtos.LandLordInformationDtos;
using StudentHousingAccomodation.Domain.Dtos.PropertyImageDtos;

namespace StudentHousingAccomodation.Domain.Dtos.RoomInformationDto
{
    public class GetTheRoomInformationDto
    {
        public string RoomDescription { get; set; }
        public decimal RoomMonthlyRent { get; set; }
        public string IsAvailable { get; set; } //occupied,pending,coming soon or available
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public List<GetThePropertyImageDto>? RoomImages { get; set; }
        public GetTheLandLordInformationDto? LandLordInformationDto { get; set; }
    }
}