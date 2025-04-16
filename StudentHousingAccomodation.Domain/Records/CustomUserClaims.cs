using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Domain.Records
{
    public record CustomUserClaims(string Id = null!, string name = null!, string Email = null!, string Role = null!)
    {
    }
}