using ItemMicroservice.Application.DTOs;
using ItemMicroservice.Application.Interfaces;
using ItemMicroservice.Application.Mappers;
using ItemMicroservice.Application.Parameters;
using ItemMicroservice.Domain.Exceptions;
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
        public async Task<ItemGetDto> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var result = await _itemRepository.GetByIdAsync(id, cancellationToken);

            if (result is null) throw new EntityNotFoundException();

            return result.ToItemGetDto();
        }
        public async Task<IEnumerable<ItemGetDto>> GetAllItemsAsync(PaginationParameter pagination, CancellationToken cancellationToken = default)
        {
            var take = pagination.PageSize;
            var skip = pagination.PageSize * (pagination.PageNumber - 1);
            return (await _itemRepository.GetAsync(take, skip, cancellationToken: cancellationToken)).Select(itm => itm.ToItemGetDto());
        }
        public async Task<ItemGetDto> CreateAsync(ItemCreateDto createDto, CancellationToken cancellationToken = default)
        {
            var entity = createDto.ToItem();
            _itemRepository.Create(entity);
            await _itemRepository.SaveAsync(cancellationToken);

            return entity.ToItemGetDto();
        }
        public async Task<ItemGetDto> UpdateAsync(Guid id, ItemUpdateDto updateDto, CancellationToken cancellationToken = default)
        {
            var entity = await _itemRepository.GetByIdAsync(id);

            if (entity is null) throw new EntityNotFoundException();

            entity.ApplyUpdateDto(updateDto);

            _itemRepository.Update(entity);
            await _itemRepository.SaveAsync(cancellationToken);

            return entity.ToItemGetDto();
        }
        public async Task SoftDeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var entity = await _itemRepository.GetByIdAsync(id, cancellationToken);

            if (entity is null) throw new EntityNotFoundException();

            _itemRepository.SoftDelete(entity);
            await _itemRepository.SaveAsync(cancellationToken);
        }
    }
}
