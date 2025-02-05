using ItemMicroservice.Domain.Entities;

namespace ItemMicroservice.Domain.Interfaces
{
    public interface IBaseRepository<TEntity, TKey> 
        where TEntity : BaseEntity<TKey> 
        where TKey : IEquatable<TKey>
    {
        Task<IEnumerable<TEntity>> GetAsync(int take = int.MaxValue, int skip = 0, CancellationToken cancellationToken = default);
        Task<TEntity?> GetByIdAsync(TKey id, CancellationToken cancellationToken = default);
        TEntity Create(TEntity item);
        TEntity Update(TEntity item);
        void SoftDelete(TEntity item);
        void HardDelete(TEntity entity);
        void Restore(TEntity entity);
        Task SaveAsync(CancellationToken cancellationToken = default);
    }
}
