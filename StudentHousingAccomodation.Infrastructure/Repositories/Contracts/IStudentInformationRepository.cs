using StudentHousingAccomodation.Domain.Entities;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Contracts
{
    public interface IStudentInformationRepository : IGenericRepository<StudentInformation>
    {
        public Task<StudentInformation> GetStudentInformationByUserId(Guid userId);
    }
}