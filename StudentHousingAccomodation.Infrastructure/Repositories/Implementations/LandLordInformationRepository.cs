using StudentHousingAccomodation.Data.Data;
using StudentHousingAccomodation.Domain.Entities;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Implementations
{
    public class LandLordInformationRepository : GenericRepository<LandLordInformation>, ILandLordInformationRepository
    {
        public LandLordInformationRepository(AppDbContext _db) : base(_db)
        {
        }

        public Task<LandLordInformation> GetLandLordInformationByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}