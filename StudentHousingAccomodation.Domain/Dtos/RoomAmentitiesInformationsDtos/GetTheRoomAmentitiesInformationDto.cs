using StudentHousingAccomodation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Domain.Dtos.RoomAmentitiesInformationsDtos
{
    public class GetTheRoomAmentitiesInformationDto
    {
        public string? AmentiesName { get; set; } //e.g. "High-speed internet", "Free parking", "24/7 access"
    }
}