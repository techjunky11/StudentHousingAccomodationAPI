using StudentHousingAccomodation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Domain.Dtos.PropertyRatingDtos
{
    public class GetThePropertyRatingDto
    {
        public int Rating { get; set; } // 1 to 5
        public string? Comment { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Guid PropertyInformationId { get; set; }
        public Guid StudentInformationId { get; set; }
        public StudentInformation? StudentInformation { get; set; }
    }
}