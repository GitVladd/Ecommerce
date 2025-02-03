using ItemMicroservice.Application.DTOs;
using ItemMicroservice.Domain.Entities;

namespace ItemMicroservice.Application.Mappers
{
    internal static class ItemUpdateDtoMapperExtensions
    {
        public static ItemUpdateDto ToItemUpdateDto(this Item item)
        {
            return new ItemUpdateDto
            {

            }
        }

        public static Item ToItem(this ItemUpdateDto item)
        {
            return new Item
            {

            }
        }
    }
}
