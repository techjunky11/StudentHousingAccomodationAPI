using StudentHousingAccomodation.Data.Data;
using StudentHousingAccomodation.Domain.Entities;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Implementations
{
    public class PropertyInformationRepository : GenericRepository<PropertyInformation>, IPropertyInformationRepository
    {
        public PropertyInformationRepository(AppDbContext _db) : base(_db)
        {
        }
    }
}