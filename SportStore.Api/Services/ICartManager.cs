using SportStore.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.Api.Services
{
    public interface ICartManager
    {
        void AddToCart(int ProductId);
        void RemoveFromCart(int ProductId);
        decimal GetCartTotalPrice();
        int GetCartTotalCount();
        List<CartItemViewModel> GetCart();
        OrderViewModel CreateOrder(OrderViewModel Order, Guid UserId);
        void EmptyCart();
    }
}
