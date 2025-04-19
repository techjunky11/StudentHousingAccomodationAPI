using StudentHousingAccomodation.Domain.Entities;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Contracts
{
    public interface IPropertyRatingRepository : IGenericRepository<PropertyRating>
    {
        public Task<List<PropertyRating>> GetPropertyRatingByPropertyId(Guid Propertyid);

        public Task<List<PropertyRating>> GetPropertyRatingByStudentId(Guid Studentid);
    }
}