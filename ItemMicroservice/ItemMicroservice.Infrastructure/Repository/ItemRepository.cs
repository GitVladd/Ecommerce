using ItemMicroservice.Domain.Entities;
using ItemMicroservice.Domain.Interfaces;
using ItemMicroservice.Infrastructure.Data;
using TEntityMicroservice.Infrastructure.Repository;

namespace ItemMicroservice.Infrastructure.Repository
{
    public class ItemRepository : BaseRepository<Item, Guid>, IItemRepository
    {
        public ItemRepository(ItemDbContext dbContext) : base(dbContext) { }
    }
}
