using StudentHousingAccomodation.Domain.Dtos.LandLordInformationDtos;
using StudentHousingAccomodation.Domain.Dtos.PropertyAmentitiesInformationDtos;
using StudentHousingAccomodation.Domain.Dtos.PropertyImageDtos;
using StudentHousingAccomodation.Domain.Dtos.PropertyRatingDtos;
using StudentHousingAccomodation.Domain.Dtos.RoomInformationDto;
using StudentHousingAccomodation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Domain.Dtos.PropertyInformationDtos
{
    public class GetThePropertyInformationDto
    {
        public string PropertyName { get; set; }

        public string PropertyDescription { get; set; }
        public decimal PropertyMonthlyRent { get; set; }
        public string IsAvailable { get; set; } //occupied,pending,coming soon or available
        public DateTime DateCreated { get; set; }
        public string TitleDeedsOrBillUrl { get; set; }
        public bool PropertyIsApprovedByAdmin { get; set; }
        public string PropertyAddress { get; set; }
        public decimal? PropertyLatitudeCoordinates { get; set; }
        public decimal? PropertLongitudeCoordinates { get; set; }
        public string PropertyType { get; set; }
        public List<GetThePropertyAmentitiesInformationDto>? AmentiesDto { get; set; }
        public List<GetThePropertyImageDto>? PropertyImagesDto { get; set; }
        public List<GetThePropertyRatingDto>? PropertyRatingsDto { get; set; }
        public List<GetTheRoomInformationDto>? PropertyRoomsDto { get; set; }
        public GetTheLandLordInformationDto? LandLordInformationDto { get; set; }
    }
}