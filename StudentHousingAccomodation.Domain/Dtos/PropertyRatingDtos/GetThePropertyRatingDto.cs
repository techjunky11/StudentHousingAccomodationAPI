﻿using StudentHousingAccomodation.Domain.Entities;

namespace StudentHousingAccomodation.Domain.Dtos.PropertyRatingDtos
{
    public class GetThePropertyRatingDto
    {
        public int Rating { get; set; } // 1 to 5
        public string? Comment { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public StudentInformation? StudentInformation { get; set; }
    }
}