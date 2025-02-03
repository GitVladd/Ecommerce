using ItemMicroservice.Application.DTOs;
using ItemMicroservice.Application.Interfaces;
using ItemMicroservice.Application.Parameters;
using ItemMicroservice.Domain.Interfaces;

namespace ItemMicroservice.Application.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public Task<ItemGetDto> CreateAsync(ItemCreateDto createDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ItemGetDto>> GetAllItemsAsync(PaginationParameter pagination)
        {
            throw new NotImplementedException();
        }

        public Task<ItemGetDto?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ItemGetDto> UpdateAsync(ItemUpdateDto updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
