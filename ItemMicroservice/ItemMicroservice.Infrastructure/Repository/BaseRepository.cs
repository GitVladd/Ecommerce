using ItemMicroservice.Domain.Entities;
using ItemMicroservice.Domain.Interfaces;
using ItemMicroservice.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace TEntityMicroservice.Infrastructure.Repository
{
    public abstract class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey>
        where TEntity : BaseEntity<TKey>
        where TKey : IEquatable<TKey>
    {

        protected ItemDbContext _dbContext;
        public BaseRepository(ItemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<TEntity>> GetAsync(int take = int.MaxValue, int skip = 0, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Set<TEntity>().Skip(take).Take(skip).ToListAsync(cancellationToken);
        }

        public async Task<TEntity?> GetByIdAsync(TKey id, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id, cancellationToken);
        }

        public TEntity Create(TEntity entity)
        {
            entity.CreatedAt = DateTime.Now;
            _dbContext.Set<TEntity>().Add(entity);
            return entity;
        }
        public TEntity Update(TEntity entity)
        {
            entity.UpdatedAt = DateTime.Now;
            _dbContext.Set<TEntity>().Update(entity);
            return entity;
        }
        public void SoftDelete(TEntity entity)
        {
            entity.DeletedAt = DateTime.Now;
            entity.IsDeleted = true;
        }

        public void HardDelete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public void Restore(TEntity entity)
        {
            if (!entity.IsDeleted)
                throw new InvalidOperationException("Entity is not deleted.");

            entity.IsDeleted = false;
            entity.DeletedAt = null;
            entity.UpdatedAt = DateTime.Now;
        }

        public async Task SaveAsync(CancellationToken cancellationToken = default)
        {
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
