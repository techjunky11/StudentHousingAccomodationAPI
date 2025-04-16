namespace StudentHousingAccomodation.Domain.Entities
{
    public class RefreshTokens
    {
        public Guid Id { get; set; }
        public string? Token { get; set; }
        public Guid UserId { get; set; }
    }
}