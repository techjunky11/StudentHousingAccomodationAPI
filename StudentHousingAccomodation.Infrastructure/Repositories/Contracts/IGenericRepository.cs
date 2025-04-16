using StudentHousingAccomodation.Domain.Records;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(Guid id);

        Task<IReadOnlyList<T>> GetAll();

        Task<GeneralResponse> Add(T entity);

        Task<GeneralResponse> Delete(Guid id);

        Task<GeneralResponse> Update(T entity);
    }
}