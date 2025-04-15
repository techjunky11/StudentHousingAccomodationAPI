using StudentHousingAccomodation.Domain.Entities;

namespace StudentHousingAccomodation.Domain.Dtos.LandLordInformationDtos
{
    public class GetTheLandLordInformationDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<PropertyInformation>? Properties { get; set; }
    }
}