using StudentHousingAccomodation.Domain.Entities;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Contracts
{
    public interface IStudentInterestsRepository : IGenericRepository<StudentInterests>
    {
        public Task<List<StudentInterests>> GetStudentInterestsByStudentId(Guid studentId);
    }
}