using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Domain.Entities
{
    public class LandLordInformation
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string LandLordName { get; set; }
        public string LandLordEmail { get; set; }
        public string LandLordPhoneNumber { get; set; }
        public string LandLordIdUrl { get; set; } //e.g. "https://example.com/id.jpg"
        public string LandLordProfileImageUrl { get; set; }
        public List<PropertyInformation>? Properties { get; set; }
    }
}