using StudentHousingAccomodation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Contracts
{
    public interface IPropertyRatingRepository : IGenericRepository<PropertyRating>
    {
        public Task<List<PropertyRating>> GetPropertyRatingByPropertyId(Guid Propertyid);

        public Task<List<PropertyRating>> GetPropertyRatingByStudentId(Guid Studentid);
    }
}