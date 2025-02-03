using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ItemMicroservice.Domain.Entities
{
    public abstract class BaseEntity<TKey> where TKey : IEquatable<TKey>
    {
        [Key]
        public TKey Id { get; set; }

        [Column(TypeName = "DateTime2")]
        [JsonIgnore]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column(TypeName = "DateTime2")]
        [JsonIgnore]
        public DateTime? UpdatedAt { get; set; }

        [Column(TypeName = "DateTime2")]
        [JsonIgnore]
        public DateTime? DeletedAt { get; set; }

        [Required]
        [JsonIgnore]
        public bool IsDeleted { get; set; } = false;
    }
}
