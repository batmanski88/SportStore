using SportStore.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.Repository.ISportStoreRepo
{
    public interface IOrderItemRepo
    {
        Task<OrderItem> GetOrderItemByIdAsync(Guid OrderItemId);
        Task<IEnumerable<OrderItem>> GetOrderItemsAsync();
        Task AddOrderItemAsync(OrderItem OrderItem);
        Task UpdateOrderItemAsync(OrderItem OrderItem);
        Task RemoveOrderItemAsync(Guid OrderItemId);
    }
}
