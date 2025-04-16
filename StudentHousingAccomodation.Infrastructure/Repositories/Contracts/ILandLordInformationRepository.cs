using StudentHousingAccomodation.Domain.Entities;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Contracts
{
    public interface ILandLordInformationRepository : IGenericRepository<LandLordInformation>
    {
        public Task<LandLordInformation> GetLandLordInformationByUserId(Guid userId);
    }
}