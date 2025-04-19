using StudentHousingAccomodation.Data.Data;
using StudentHousingAccomodation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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