using ItemMicroservice.Application.DTOs;
using ItemMicroservice.Domain.Entities;

namespace ItemMicroservice.Application.Mappers
{
    internal static class ItemGetDtoMapperExtensions
    {
        public static ItemGetDto ToItemGetDto(this Item item)
        {
            return new ItemGetDto
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                Price = item.Price
            };
        }

        public static Item ToItem(this ItemGetDto item)
        {
            return new Item
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                Price = item.Price
            };
        }
    }
}
