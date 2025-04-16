using StudentHousingAccomodation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Contracts
{
    public interface IPropertyAmentiesInformationRepository : IGenericRepository<PropertyAmentiesInformation>
    {
        public List<PropertyAmentiesInformation> GetPropertyAmentiesInformationByPropertyId(Guid propertyId);
    }
}