using StudentHousingAccomodation.Data.Data;
using StudentHousingAccomodation.Domain.Entities;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Implementations
{
    public class StudentInterestsRepository : GenericRepository<StudentInterests>, IStudentInterestsRepository
    {
        public StudentInterestsRepository(AppDbContext _db) : base(_db)
        {
        }

        public Task<List<StudentInterests>> GetStudentInterestsByStudentId(Guid studentId)
        {
            throw new NotImplementedException();
        }
    }
}