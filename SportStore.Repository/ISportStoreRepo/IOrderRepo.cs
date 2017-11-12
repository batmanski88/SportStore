using SportStore.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.Repository.ISportStoreRepo
{
    public interface IOrderRepo
    {
        Task<Order> GetOrderByIdAsync(Guid OrderId);
        Task<IEnumerable<Order>> GetOrdersAsync();
        Task AddOrderAsync(Order Order);
        Task UpdateOrderAsync(Order Order);
        Task RemoveOrderAsync(Guid OrderId);
    }
}
