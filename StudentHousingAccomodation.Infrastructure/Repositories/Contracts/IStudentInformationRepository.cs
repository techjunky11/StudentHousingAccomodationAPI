using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentHousingAccomodation.Domain.Entities;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Contracts
{
    public interface IStudentInformationRepository : IGenericRepository<StudentInformation>
    {
        public Task<StudentInformation> GetStudentInformationByUserId(Guid userId);
    }
}