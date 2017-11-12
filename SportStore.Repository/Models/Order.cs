using System;
using System.Collections.Generic;
using System.Text;

namespace SportStore.Repository.Models
{
    public class Order
    {
        public Guid OrderId { get; protected set; }
        public Guid UserId { get; protected set; }
        public string Comment { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public OrderState OrderState { get; protected set; }
        public decimal TotalPrice { get; protected set; }
        public User User { get; protected set; }

        public Order(Guid orderId, Guid userId, string comment, OrderState orderState, decimal totalPrice)
        {
            OrderId = orderId;
            SetUserId(userId);
            SetComment(comment);
            SetOrderState(OrderState);
            SetTotalPrice(totalPrice);
        }

        public void SetUserId(Guid userId)
        {
            UserId = userId;
        }

        public void SetComment(string comment)
        {
            if(Comment == comment)
            {
                return;
            }
            Comment = comment;
        }

        public void SetOrderState(OrderState orderState)
        {
            OrderState = orderState;
        }

        public void SetTotalPrice(decimal totalPrice)
        {
            if(TotalPrice == totalPrice)
            {
                return;
            }
            TotalPrice = totalPrice;
        }
    }

    public enum OrderState
    {
        New,
        Shippded
    }
}
