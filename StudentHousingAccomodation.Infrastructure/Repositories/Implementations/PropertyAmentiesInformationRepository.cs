using StudentHousingAccomodation.Data.Data;
using StudentHousingAccomodation.Domain.Entities;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Implementations
{
    public class PropertyAmentiesInformationRepository : GenericRepository<PropertyAmentiesInformation>, IPropertyAmentiesInformationRepository
    {
        public PropertyAmentiesInformationRepository(AppDbContext _db) : base(_db)
        {
        }

        public List<PropertyAmentiesInformation> GetPropertyAmentiesInformationByPropertyId(Guid propertyId)
        {
            throw new NotImplementedException();
        }
    }
}