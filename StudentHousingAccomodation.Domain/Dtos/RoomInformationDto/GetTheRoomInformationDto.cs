using StudentHousingAccomodation.Domain.Dtos.LandLordInformationDtos;
using StudentHousingAccomodation.Domain.Dtos.RoomAmentitiesInformationsDtos;
using StudentHousingAccomodation.Domain.Dtos.RoomImageDtos;
using StudentHousingAccomodation.Domain.Dtos.RoomRatingDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<GetTheRoomImageDto>? RoomImages { get; set; }
        public List<GetTheRoomRatingDto>? RoomRatings { get; set; }
        public List<GetTheRoomAmentitiesInformationDto>? RoomAmenties { get; set; }
        public GetTheLandLordInformationDto? LandLordInformationDto { get; set; }
    }
}