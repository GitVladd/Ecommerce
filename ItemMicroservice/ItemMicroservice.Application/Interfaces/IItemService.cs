using ItemMicroservice.Application.DTOs;
using ItemMicroservice.Application.Parameters;

namespace ItemMicroservice.Application.Interfaces
{
    public interface IItemService
    {
        Task<IEnumerable<ItemGetDto>> GetAllItemsAsync(PaginationParameter pagination);

        Task<ItemGetDto?> GetByIdAsync(Guid id);

        Task<ItemGetDto> CreateAsync(ItemCreateDto createDto);

        Task<ItemGetDto> UpdateAsync(ItemUpdateDto updateDto);

        Task DeleteAsync(Guid id);

    }
}
