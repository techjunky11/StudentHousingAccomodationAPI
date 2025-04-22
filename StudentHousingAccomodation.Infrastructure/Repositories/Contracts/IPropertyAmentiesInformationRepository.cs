using StudentHousingAccomodation.Domain.Entities;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Contracts
{
    public interface IPropertyAmentiesInformationRepository : IGenericRepository<PropertyAmentiesInformation>
    {
        public List<PropertyAmentiesInformation> GetPropertyAmentiesInformationByPropertyId(Guid propertyId);
    }
}