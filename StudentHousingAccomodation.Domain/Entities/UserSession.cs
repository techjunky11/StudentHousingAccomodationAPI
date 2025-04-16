namespace StudentHousingAccomodation.Domain.Entities
{
    public class UserSession
    {
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }
    }
}