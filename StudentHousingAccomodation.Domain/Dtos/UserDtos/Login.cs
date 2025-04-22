using System.ComponentModel.DataAnnotations;

namespace StudentHousingAccomodation.Domain.Dtos.UserDtos
{
    public class Login
    {
        public string? EmailAddress { get; set; }

        public string? Password { get; set; }
    }
}