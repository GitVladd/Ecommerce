﻿
using System.ComponentModel.DataAnnotations;

namespace ItemMicroservice.Domain.Entities
{
    public class Item : BaseEntity<Guid>
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
