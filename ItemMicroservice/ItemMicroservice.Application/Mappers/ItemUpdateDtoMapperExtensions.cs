using ItemMicroservice.Application.DTOs;
using ItemMicroservice.Domain.Entities;

namespace ItemMicroservice.Application.Mappers
{
    internal static class ItemUpdateDtoMapperExtensions
    {
        public static void ApplyUpdateDto(this Item item, ItemUpdateDto dto)
        {
            item.Name = dto.Name;
            item.Description = dto.Description;
            item.Price = dto.Price;
        }
    }
}
