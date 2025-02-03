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

            }
        }

        public static Item ToItem(this ItemGetDto item)
        {
            return new Item
            {

            }
        }
    }
}
