﻿namespace StudentHousingAccomodation.Domain.Dtos.StudentInterestsDtos
{
    public class CreateNewStudentInterestsDto
    {
        public string Interest { get; set; } //e.g. "Sports", "Music", "Art", etc
        public Guid StudentInformationId { get; set; } //Foreign key property
    }
}