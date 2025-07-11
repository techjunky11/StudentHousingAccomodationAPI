﻿using StudentHousingAccomodation.Data.Data;
using StudentHousingAccomodation.Domain.Entities;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Implementations
{
    public class PropertyImageRepository : GenericRepository<PropertyImage>, IPropertyImageRepository
    {
        public PropertyImageRepository(AppDbContext _db) : base(_db)
        {
        }

        public Task<List<PropertyImage>> GetPropertyImageByPropertyIdAsync(Guid ProprtyId)
        {
            throw new NotImplementedException();
        }

        public Task<List<PropertyImage>> GetPropertyImageByRoomIdAsync(Guid RoomId)
        {
            throw new NotImplementedException();
        }
    }
}