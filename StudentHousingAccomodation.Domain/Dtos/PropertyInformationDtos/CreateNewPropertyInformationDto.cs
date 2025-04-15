using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Domain.Dtos.PropertyInformationDtos
{
    public class CreateNewPropertyInformationDto
    {
        public CreateNewPropertyInformationDto()
        {
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }

        public string PropertyName { get; set; }
        public string PropertyDescription { get; set; }
        public decimal PropertyMonthlyRent { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string? TitleDeedsOrBillUrl { get; set; }
        public string PropertyAddress { get; set; }
        public decimal? PropertyLatitudeCoordinates { get; set; }
        public decimal? PropertLongitudeCoordinates { get; set; }
        public string PropertyType { get; set; }
        public Guid LandLordInformationId { get; set; }
    }
}