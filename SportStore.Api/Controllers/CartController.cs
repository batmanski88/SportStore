using SportStore.Api.Services;
using SportStore.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportStore.Api.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartManager _cartManager;
        
        public CartController(ICartManager cartManager)
        {
            _cartManager = cartManager;
        }

        public ActionResult Index()
        {
            var cartItems = _cartManager.GetCart();
            var totalPrice = _cartManager.GetCartTotalPrice();

            CartViewModel viewModel = new CartViewModel()
            {
                CartItems = cartItems,
                TotalPrice = totalPrice
            };
            return View(viewModel);
        }

        public ActionResult AddToCart(Guid ProductId)
        {
            _cartManager.AddToCart(ProductId);
            return RedirectToAction("Index");
        }

        public ActionResult RemoveFromCart(Guid ProductId)
        {
            return View();
        }
    }
}