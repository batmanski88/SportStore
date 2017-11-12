using SportStore.Repository.ISportStoreRepo;
using System;
using System.Collections.Generic;
using System.Text;
using SportStore.Repository.Models;
using System.Threading.Tasks;

namespace SportStore.Repository.SportStoreRepo
{
    public class OrderRepo : IOrderRepo
    {
        public Task AddOrderAsync(Order Order)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderByIdAsync(Guid OrderId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetOrdersAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoveOrderAsync(Guid OrderId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrderAsync(Order Order)
        {
            throw new NotImplementedException();
        }
    }
}
