using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStore.Api.ViewModels
{
    public class OrderViewModel
    {
        public Guid OrderId { get; set; }
        public Guid UserId { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public OrderState OrderState { get; set; }
        public decimal TotalPrice { get; set; }    
        public List<OrderItemViewModel> OrderItems { get; set; }
    }


    public enum OrderState
    {
        New,
        Shippded
    }
}