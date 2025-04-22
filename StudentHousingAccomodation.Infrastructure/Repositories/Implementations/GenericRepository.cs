using Microsoft.EntityFrameworkCore;
using StudentHousingAccomodation.Data.Data;
using StudentHousingAccomodation.Domain.Records;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext db;

        public GenericRepository(AppDbContext _db)
        {
            db = _db;
        }

        public virtual async Task<GeneralResponse> Add(T entity)
        {
            db.Set<T>().Add(entity);
            await db.SaveChangesAsync();
            return new GeneralResponse(true, "Added");
        }

        public virtual async Task<GeneralResponse> Delete(Guid id)
        {
            var model = db.Set<T>().Find(id)!;
            if (model == null) return new GeneralResponse(false, "not found");
            db.Set<T>().Remove(model);
            await db.SaveChangesAsync();
            return new GeneralResponse(true, "Successfully deleted ");
        }

        public virtual T Get(Guid id)
        {
            return db.Set<T>().Find(id)!;
        }

        public virtual async Task<IReadOnlyList<T>> GetAll()
        {
            return await db.Set<T>().ToListAsync();
        }

        public virtual async Task<GeneralResponse> Update(T entity)
        {
            db.Set<T>().Update(entity);
            await db.SaveChangesAsync();// Save changes to the repository

            return new GeneralResponse(true, "Entity updated successfully"); ;
        }
    }
}