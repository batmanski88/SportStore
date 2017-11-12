using System;
using System.Collections.Generic;
using System.Text;

namespace SportStore.Repository.Models
{
    public class OrderItem
    {
        public Guid OrderItemId {get; protected set; }
        public Guid OrderId { get; protected set; }
        public Guid ProductId { get; protected set; }
        public int Quantity { get; protected set; }
        public decimal UnitPrice { get; protected set; }
        public virtual Product Product { get; protected set; }
        public virtual Order Order { get; protected set; }

        public OrderItem(Guid orderItemId, Guid orderId, Guid productId, int quantity, decimal unitPrice)
        {
            OrderItemId = orderItemId;
            SetOrderId(orderId);
            SetProductId(productId);
            SetQuantity(quantity);
            SetUnitPrice(unitPrice);
        }

        public void SetOrderId(Guid orderId)
        {
            OrderId = orderId;
        }

        public void SetProductId(Guid productId)
        {
            ProductId = productId;
        }

        public void SetQuantity(int quantity)
        {
            if(Quantity == quantity)
            {
                return;
            }
            Quantity = quantity;
        }

        public void SetUnitPrice(decimal unitPrice)
        {
            if(UnitPrice == unitPrice)
            {
                return;
            }
            UnitPrice = unitPrice;
        }
    }
}
