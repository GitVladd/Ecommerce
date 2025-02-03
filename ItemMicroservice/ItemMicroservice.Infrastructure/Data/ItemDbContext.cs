using ItemMicroservice.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ItemMicroservice.Infrastructure.Data
{
    public class ItemDbContext : DbContext
    {
        public DbSet<Item> Items => Set<Item>();

        public ItemDbContext(DbContextOptions<ItemDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Item>().HasQueryFilter(i => !i.IsDeleted);

            //modelBuilder.Entity<Category>()
            //    .HasIndex(c => c.Name)
            //    .IsUnique();


            //modelBuilder.Entity<Category>().HasData(
            //    new Category { Id = Guid.NewGuid(), Name = "Computers" },
            //    new Category { Id = Guid.NewGuid(), Name = "Food" },
            //    new Category { Id = Guid.NewGuid(), Name = "Cars" }
            //);
        }
    }
}
