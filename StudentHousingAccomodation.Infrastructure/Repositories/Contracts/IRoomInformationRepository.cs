using StudentHousingAccomodation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Contracts
{
    public interface IRoomInformationRepository : IGenericRepository<RoomInformation>
    {
        public Task<List<RoomInformation>> GetRoomInformationByPropertyId(int propertyId);
    }
}