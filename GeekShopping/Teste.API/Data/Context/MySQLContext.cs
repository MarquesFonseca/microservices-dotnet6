using GeekShopping.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Data.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Produto 1",
                CategoryName = "T-shirt",
                Description = "Descriçao do produto, Descriçao do produto, Descriçao do produto, Descriçao do produto, ",
                Price = new decimal(69.90),
                ImageUrl = "http://url"
            });
        }
    }
}
