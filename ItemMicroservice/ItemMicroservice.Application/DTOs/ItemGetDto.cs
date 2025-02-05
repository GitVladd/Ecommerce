using System.Text.Json.Serialization;

namespace ItemMicroservice.Application.DTOs
{
    public class ItemGetDto : ItemBaseDto
    {
        [JsonPropertyOrder(-1)]
        public Guid Id { get; set; }
    }
}
