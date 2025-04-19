namespace StudentHousingAccomodation.Domain.Dtos.UserDtos
{
    public class UserSession
    {
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }
    }
}