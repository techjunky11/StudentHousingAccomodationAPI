using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Domain.Dtos.RoomInformationDto
{
    internal class UpdateRoomInformationDto
    {
        public string RoomDescription { get; set; }
        public decimal RoomMonthlyRent { get; set; }
        public string IsAvailable { get; set; } //occupied,pending,coming soon or available
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public List<RoomImage>? RoomImages { get; set; }
        public List<RoomRating>? RoomRatings { get; set; }
        public List<RoomAmentiesInformation>? RoomAmenties { get; set; }
        public StudentInformation? StudentInformation { get; set; }
        public Guid StudentInformationId { get; set; }
    }
}