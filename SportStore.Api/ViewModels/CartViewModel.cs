using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStore.Api.ViewModels
{
    public class CartViewModel
    {
        public List<CartItemViewModel> CartItems { get; set; }
        public decimal TotalPrice { get; set; }
    }
}