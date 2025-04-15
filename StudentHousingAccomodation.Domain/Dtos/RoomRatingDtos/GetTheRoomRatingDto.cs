using StudentHousingAccomodation.Domain.Dtos.StudentInformationDtos;
using StudentHousingAccomodation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Domain.Dtos.RoomRatingDtos
{
    public class GetTheRoomRatingDto
    {
        public int Rating { get; set; } //e.g. 1,2,3,4,5
        public string? Comment { get; set; } //e.g. "This room is great!"
        public DateTime DateCreated { get; set; } //e.g. 2023-01-01
        public DateTime DateModified { get; set; } //e.g. 2023-01-01
        public GetTheStudentInformationDto? StudentInformationDto { get; set; } //Navigation property
    }
}