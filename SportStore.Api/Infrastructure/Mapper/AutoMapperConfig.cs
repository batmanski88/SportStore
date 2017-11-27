using AutoMapper;
using SportStore.Api.ViewModels;
using SportStore.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStore.Api.Infrastructure.Mapper
{
    public static class AutoMapperConfig
    {

        public static IMapper Initialize() =>
            new MapperConfiguration(cfg =>
           {
               cfg.CreateMap<Category, CategoryViewModel>();
               cfg.CreateMap<Product, ProductViewModel>();
               cfg.CreateMap<Order, OrderViewModel>();
               cfg.CreateMap<Product, AddProductViewModel>();
               cfg.CreateMap<Order, OrderViewModel>();
               cfg.CreateMap<OrderItem, OrderItemViewModel>();

           }).CreateMapper();
        
    }
}