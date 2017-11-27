using SportStore.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStore.Api.ViewModels
{
    public class CartItemViewModel
    {
        public ProductViewModel Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}