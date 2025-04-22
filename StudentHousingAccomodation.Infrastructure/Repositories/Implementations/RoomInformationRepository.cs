using StudentHousingAccomodation.Data.Data;
using StudentHousingAccomodation.Domain.Entities;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

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