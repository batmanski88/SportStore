using System.Threading.Tasks;
using SportStore.Repository.ISportStoreRepo;
using SportStore.Repository.Models;
using System.Data.Entity;


namespace SportStore.Repository.SportStoreRepo
{
    public class StoreContext : DbContext, IStoreContext
    {
        public StoreContext()
            :base("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\batman\\Documents\\SportStoreDB.mdf;Integrated Security=True;Connect Timeout=30")
        {

        }

        public IDbSet<Category> Categories { get; set; }
        public IDbSet<Product> Products { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<Order> Orders { get; set; }
        public IDbSet<OrderItem> OrderItems { get; set; }

        public override async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
