using StudentHousingAccomodation.Domain.Entities;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Contracts
{
    public interface IRoomInformationRepository : IGenericRepository<RoomInformation>
    {
        public Task<List<RoomInformation>> GetRoomInformationByPropertyId(int propertyId);
    }
}