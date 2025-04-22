using StudentHousingAccomodation.Domain.Entities;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Contracts
{
    public interface IPropertyImageRepository : IGenericRepository<PropertyImage>
    {
        public Task<List<PropertyImage>> GetPropertyImageByPropertyIdAsync(Guid ProprtyId);

        public Task<List<PropertyImage>> GetPropertyImageByRoomIdAsync(Guid RoomId);
    }
}