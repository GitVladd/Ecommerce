using System.ComponentModel.DataAnnotations;

namespace ItemMicroservice.Application.DTOs
{
    public abstract class ItemBaseDto
    {
        [Required]
        public string Name;

        [Required]
        public string Description;

        [Required]
        [Range(0.01, double.PositiveInfinity)]
        public decimal Price;
    }
}
