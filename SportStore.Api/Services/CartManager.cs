using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportStore.Api.ViewModels;

namespace SportStore.Api.Services
{
    public class CartManager : ICartManager
    {
        public void AddToCart(int ProductId)
        {
            throw new NotImplementedException();
        }

        public OrderViewModel CreateOrder(OrderViewModel Order, Guid UserId)
        {
            throw new NotImplementedException();
        }

        public void EmptyCart()
        {
            throw new NotImplementedException();
        }

        public List<CartItemViewModel> GetCart()
        {
            throw new NotImplementedException();
        }

        public int GetCartTotalCount()
        {
            throw new NotImplementedException();
        }

        public decimal GetCartTotalPrice()
        {
            throw new NotImplementedException();
        }

        public void RemoveFromCart(int ProductId)
        {
            throw new NotImplementedException();
        }
    }
}