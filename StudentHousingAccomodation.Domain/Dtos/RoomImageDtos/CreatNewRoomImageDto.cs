using StudentHousingAccomodation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Domain.Dtos.RoomImageDtos
{
    public class CreatNewRoomImageDto
    {
        public string ImageUrl { get; set; }
        public string ImageDescription { get; set; }
        public string ImageType { get; set; } //e.g. front view, back view, side view, etc
        public string ImageName { get; set; } //e.g. front view, back view, side view, etc
        public string ImageSize { get; set; } //e.g. 1MB, 2MB, etc
        public string ImageFormat { get; set; } //e.g. jpg, png, etc
        public string ImageResolution { get; set; } //e.g. 1920x1080, 1280x720, etc
        public Guid RoomInformationId { get; set; } //Foreign key property
    }
}