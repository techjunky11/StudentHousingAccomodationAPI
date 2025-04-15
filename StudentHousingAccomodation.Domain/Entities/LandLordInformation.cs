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
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? ProfilePictureUrl { get; set; } // URL to the profile picture
        public Guid UserId { get; set; } // Foreign key property
        public List<PropertyInformation>? Properties { get; set; }
    }
}