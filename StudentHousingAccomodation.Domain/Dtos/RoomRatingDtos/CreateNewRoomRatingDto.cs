using StudentHousingAccomodation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Domain.Dtos.RoomRatingDtos
{
    public class CreateNewRoomRatingDto
    {
        public int Rating { get; set; } //e.g. 1,2,3,4,5
        public string? Comment { get; set; } //e.g. "This room is great!"
        public Guid RoomInformationId { get; set; } //Foreign key property
        public Guid StudentInformationId { get; set; } //Foreign key property
    }
}