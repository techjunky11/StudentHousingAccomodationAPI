using StudentHousingAccomodation.Data.Data;
using StudentHousingAccomodation.Domain.Entities;

using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Implementations
{
    public class PropertyRatingRepository : GenericRepository<PropertyRating>, IPropertyRatingRepository
    {
        public PropertyRatingRepository(AppDbContext _db) : base(_db)
        {
        }

        public Task<List<PropertyRating>> GetPropertyRatingByPropertyId(Guid Propertyid)
        {
            throw new NotImplementedException();
        }

        public Task<List<PropertyRating>> GetPropertyRatingByStudentId(Guid Studentid)
        {
            throw new NotImplementedException();
        }
    }
}