using ItemMicroservice.Domain.Entities;

namespace ItemMicroservice.Domain.Interfaces
{
    public interface IItemRepository : IBaseRepository<Item, Guid>
    {
    }
}
