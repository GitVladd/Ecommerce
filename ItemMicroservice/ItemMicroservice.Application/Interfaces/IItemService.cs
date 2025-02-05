using ItemMicroservice.Application.DTOs;
using ItemMicroservice.Application.Parameters;

namespace ItemMicroservice.Application.Interfaces
{
    public interface IItemService
    {
        Task<IEnumerable<ItemGetDto>> GetAllItemsAsync(PaginationParameter pagination, CancellationToken cancellationToken = default);

        Task<ItemGetDto> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        Task<ItemGetDto> CreateAsync(ItemCreateDto createDto, CancellationToken cancellationToken = default);

        Task<ItemGetDto> UpdateAsync(Guid id, ItemUpdateDto updateDto, CancellationToken cancellationToken = default);

        Task SoftDeleteAsync(Guid id, CancellationToken cancellationToken = default);

    }
}
