using StudentHousingAccomodation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Contracts
{
    public interface IPropertyImageRepository : IGenericRepository<PropertyImage>
    {
        public Task<List<PropertyImage>> GetPropertyImageByPropertyIdAsync(Guid ProprtyId);

        public Task<List<PropertyImage>> GetPropertyImageByRoomIdAsync(Guid RoomId);
    }
}