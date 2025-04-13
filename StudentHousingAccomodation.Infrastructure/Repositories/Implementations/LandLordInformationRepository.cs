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
    public class LandLordInformationRepository : GenericRepository<LandLordInformation>, ILandLordInformationRepository
    {
        public LandLordInformationRepository(AppDbContext _db) : base(_db)
        {
        }
    }
}