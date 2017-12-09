
using SportStore.Repository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.Repository.ISportStoreRepo
{
    public interface IStoreContext
    {
        IDbSet<Category> Categories { get; set; }
        IDbSet<Product> Products { get; set; }
        IDbSet<User> Users { get; set; }
        IDbSet<Order> Orders { get; set; }
        IDbSet<OrderItem> OrderItems { get; set; }
        Task<int> SaveChangesAsync();
    }
}
