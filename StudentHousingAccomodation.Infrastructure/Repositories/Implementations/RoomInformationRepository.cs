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
    public class RoomInformationRepository : GenericRepository<RoomInformation>, IRoomInformationRepository
    {
        public RoomInformationRepository(AppDbContext _db) : base(_db)
        {
        }

        public Task<List<RoomInformation>> GetRoomInformationByPropertyId(int propertyId)
        {
            throw new NotImplementedException();
        }
    }
}