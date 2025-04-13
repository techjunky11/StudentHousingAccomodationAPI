using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(int id);

        Task<IReadOnlyList<T>> GetAll();

        Task<GeneralResponse> Add(T entity);

        Task<GeneralResponse> Delete(int id);

        Task<GeneralResponse> Update(T entity);
    }
}