using StudentHousingAccomodation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Domain.Dtos.RoomInformationDto
{
    public class CreateNewRoomInformationDto
    {
        public string RoomDescription { get; set; }
        public decimal RoomMonthlyRent { get; set; }
        public string IsAvailable { get; set; } //occupied,pending,coming soon or available
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public Guid PropertyInformationId { get; set; }
    }
}