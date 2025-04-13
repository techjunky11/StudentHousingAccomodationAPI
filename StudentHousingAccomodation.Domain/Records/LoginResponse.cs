using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Domain.Records
{
    public record LoginResponse(bool Flag, string Message, string Token, string RefreshToken)
    {
    }
}