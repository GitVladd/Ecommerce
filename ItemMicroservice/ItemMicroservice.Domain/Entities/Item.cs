
namespace ItemMicroservice.Domain.Entities
{
    public class Item : BaseEntity<Guid>
    {
        public string Name;

        public string Description;

        public decimal Price;
    }
}
