using Microsoft.EntityFrameworkCore;
using StudentHousingAccomodation.Data.Data;
using StudentHousingAccomodation.Domain.Records;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingAccomodation.Infrastructure.Repositories.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext db;

        public GenericRepository(AppDbContext _db)
        {
            db = _db;
        }

        public async Task<GeneralResponse> Add(T entity)
        {
            db.Set<T>().Add(entity);
            await db.SaveChangesAsync();
            return new GeneralResponse(true, "Added");
        }

        public async Task<GeneralResponse> Delete(int id)
        {
            var model = db.Set<T>().Find(id)!;
            if (model == null) return new GeneralResponse(false, "not found");
            db.Set<T>().Remove(model);
            await db.SaveChangesAsync();
            return new GeneralResponse(true, "Successfully deleted ");
        }

        public T Get(int id)
        {
            return db.Set<T>().Find(id)!;
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await db.Set<T>().ToListAsync();
        }

        public async Task<GeneralResponse> Update(T entity)
        {
            db.Set<T>().Update(entity);
            await db.SaveChangesAsync();// Save changes to the repository

            return new GeneralResponse(true, "Entity updated successfully"); ;
        }
    }
}