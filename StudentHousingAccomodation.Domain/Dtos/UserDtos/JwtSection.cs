﻿namespace StudentHousingAccomodation.Domain.Dtos.UserDtos
{
    public class JwtSection
    {
        public string? Key { get; set; }
        public string? Issuer { get; set; }
        public string? Audience { get; set; }
    }
}