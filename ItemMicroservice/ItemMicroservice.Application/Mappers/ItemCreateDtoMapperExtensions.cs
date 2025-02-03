using ItemMicroservice.Application.DTOs;
using ItemMicroservice.Domain.Entities;

namespace ItemMicroservice.Application.Mappers
{
    internal static class ItemCreateDtoMapperExtensions
    {
        public static ItemCreateDto ToItemCreateDto(this Item item)
        {
            return new ItemCreateDto
            {

            }
        }

        public static Item ToItem(this ItemCreateDto item)
        {
            return new Item
            {

            }
        }
    }
}
