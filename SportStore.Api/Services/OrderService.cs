using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SportStore.Api.ViewModels;
using SportStore.Repository.ISportStoreRepo;
using AutoMapper;
using SportStore.Repository.Models;

namespace SportStore.Api.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepo _orderRepo;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepo orderRepo, IMapper mapper)
        {
            _mapper = mapper;
            _orderRepo = orderRepo;
        }

        public async Task AddOrder(OrderViewModel model)
        {
            var order = _mapper.Map<OrderViewModel, Order>(model);
            await _orderRepo.AddOrderAsync(order);
        }
    }
}