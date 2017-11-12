using SportStore.Repository.ISportStoreRepo;
using System;
using System.Collections.Generic;
using System.Text;
using SportStore.Repository.Models;
using System.Threading.Tasks;

namespace SportStore.Repository.SportStoreRepo
{
    public class OrderItemRepo : IOrderItemRepo
    {
        public Task AddOrderItemAsync(OrderItem OrderItem)
        {
            throw new NotImplementedException();
        }

        public Task<OrderItem> GetOrderItemByIdAsync(Guid OrderItemId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderItem>> GetOrderItemsAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoveOrderItemAsync(Guid OrderItemId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrderItemAsync(OrderItem OrderItem)
        {
            throw new NotImplementedException();
        }
    }
}
