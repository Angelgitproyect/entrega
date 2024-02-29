using Core.Entities;
using Core.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Persistence.DataContext;

namespace Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly PruebaTecnicaContext _contex;
        protected readonly DbSet<T> _entities;
        public BaseRepository(PruebaTecnicaContext contex)
        {
            _contex = contex;
            _entities = contex.Set<T>();
        }

        public async Task<T> Add(T entity)
        {
            try
            {
                var result = await _entities.AddAsync(entity);
                return result.Entity;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public virtual async Task<bool> Delete(T entity)
        {
            try
            {
                _entities.Remove(entity);
            }
            catch (NotSupportedException)
            {
                return false;
            }
            return true;
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return _entities.ToList();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await _entities.FindAsync(id);
        }

        public virtual Task<T> UpdateAsync(T entity)
        {

            return Task.FromResult(_entities.Update(entity).Entity);
        }
    }
}
