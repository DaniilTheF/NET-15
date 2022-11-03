using Microsoft.EntityFrameworkCore;
using Project2.Objects.Models;

namespace Project2.Objects.DB
{
    public class DataBase : DbContext
    {
        public DataBase(DbContextOptions<DataBase> options):base(options)
        {
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<ItemProductsBasket> ItemProductsBasket { get; set; }
        public DbSet<Types> Types { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Order> Order { get; set; }

    }
}
