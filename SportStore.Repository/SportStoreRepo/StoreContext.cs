using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportStore.Repository.ISportStoreRepo;
using SportStore.Repository.Models;

namespace SportStore.Repository.SportStoreRepo
{
    public class StoreContext : DbContext, IStoreContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\batman\\Documents\\SportStoreDB.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
    }
}
