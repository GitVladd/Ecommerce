using ItemMicroservice.Application.DTOs;
using ItemMicroservice.Domain.Entities;

namespace ItemMicroservice.Application.Mappers
{
    internal static class ItemCreateDtoMapperExtensions
    {
        public static Item ToItem(this ItemCreateDto item)
        {
            return new Item
            {
                Id = Guid.NewGuid(),
                Name = item.Name,
                Description = item.Description,
                Price = item.Price
            };
        }
    }
}
