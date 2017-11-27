﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStore.Api.ViewModels
{
    public class OrderItemViewModel
    {
        public Guid OrderItemId { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}