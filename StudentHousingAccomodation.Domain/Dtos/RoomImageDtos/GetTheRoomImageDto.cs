using StudentHousingAccomodation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Domain.Dtos.RoomImageDtos
{
    public class GetTheRoomImageDto
    {
        public string ImageUrl { get; set; }
        public DateTime ImageUploadDate { get; set; } //e.g. 2023-01-01, 2023-01-02, etc
    }
}