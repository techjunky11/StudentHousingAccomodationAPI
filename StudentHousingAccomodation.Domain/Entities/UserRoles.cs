using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Domain.Entities
{
    public class UserRoles
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid RoleId { get; set; } //e.g. "Admin", "Student", "Landlord"
        public Guid userId { get; set; } // Foreign key property
    }
}