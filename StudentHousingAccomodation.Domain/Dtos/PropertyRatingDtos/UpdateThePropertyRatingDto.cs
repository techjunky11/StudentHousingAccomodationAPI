using StudentHousingAccomodation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Domain.Dtos.PropertyRatingDtos
{
    public class UpdateThePropertyRatingDto
    {
        public int Rating { get; set; } // 1 to 5
        public string? Comment { get; set; }
    }
}