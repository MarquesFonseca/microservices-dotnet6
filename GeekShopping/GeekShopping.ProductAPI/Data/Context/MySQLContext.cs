using GeekShopping.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Data.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
