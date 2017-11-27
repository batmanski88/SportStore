using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportStore.Api.ViewModels;
using System.Threading.Tasks;

namespace SportStore.Api.Services
{
    public class CartManager : ICartManager
    {

        private readonly ISessionManager _sessionManager;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;

        public const string CartSessionKey = "CartData";
        
        public CartManager(ISessionManager sessionManager, IProductService productService, IOrderService orderService)
        {
            _sessionManager = sessionManager;
            _productService = productService;
            _orderService = orderService;
        }

        public async Task AddToCart(Guid ProductId)
        {
            var products = await _productService.GetProductsAsync(); 
            
            var cart = this.GetCart();

            var cartItem = cart.Find(c => c.Product.ProductId == ProductId);

            if(cartItem != null)
            {
                cartItem.Quantity++;
            }
            else
            {
                var productToAdd = products.FirstOrDefault(x => x.ProductId == ProductId);

                if(productToAdd != null)
                {
                    var newCartItem = new CartItemViewModel()
                    {
                        Product = productToAdd,
                        Quantity = 1,
                        TotalPrice = productToAdd.Price
                    };

                    cart.Add(newCartItem);
                }
            }

            _sessionManager.Set(CartSessionKey, cart);
        }

        public OrderViewModel CreateOrder(OrderViewModel Order, Guid UserId)
        {
            var cart = this.GetCart();

            Order.CreatedAt = DateTime.UtcNow;

            _orderService.AddOrder(Order);

            if(Order.OrderItems == null)
            {
                Order.OrderItems = new List<OrderItemViewModel>();

                decimal cartTotal = 0;

                foreach(var item in cart)
                {
                    var newOrderItem = new OrderItemViewModel()
                    {
                        ProductId = item.Product.ProductId,
                        Quantity = item.Quantity,
                        UnitPrice = item.Product.Price
                    };

                    cartTotal += (item.Quantity * item.Product.Price);

                    Order.OrderItems.Add(newOrderItem);
                }

                Order.TotalPrice = cartTotal;

                
            }

            return Order;
        }
        
        public void EmptyCart()
        {
            _sessionManager.Set<List<CartItemViewModel>>(CartSessionKey, null);
        }

        public List<CartItemViewModel> GetCart()
        {
            List<CartItemViewModel> Cart;

            if(_sessionManager.Get<List<CartItemViewModel>>(CartSessionKey) == null)
            {
                Cart = new List<CartItemViewModel>();
            }
            else
            {
                Cart = _sessionManager.Get<List<CartItemViewModel>>(CartSessionKey);
            }

            return Cart;
        }

        public int GetCartTotalCount()
        {
            var cart = this.GetCart();

            int count = cart.Sum(c => c.Quantity);

            return count;
        }

        public decimal GetCartTotalPrice()
        {

            var cart = this.GetCart();

            return cart.Sum(c => (c.Quantity * c.Product.Price));
        }

        public void RemoveFromCart(Guid ProductId)
        {
            var cart = this.GetCart();

            var cartItem = cart.Find(p => p.Product.ProductId == ProductId);

            if (cartItem != null)
            {
                if(cartItem.Quantity > 1)
                {
                    cartItem.Quantity--;
                }
                else
                {
                    cart.Remove(cartItem);
                }
            }

        }
    }
}