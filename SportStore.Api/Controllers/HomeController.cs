using SportStore.Api.Services;
using SportStore.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SportStore.Api.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;

        public HomeController(ProductService productService, CategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        // GET: Home
        public async Task<ActionResult> Index()
        {
            var categories = await _categoryService.GetCategoriesAsync();
            var products = await _productService.GetProductsAsync();
            products.OrderBy(p => Guid.NewGuid()).Take(6);

            var homeViewModel = new HomeViewModel
            {
                Categories = categories,
                Products = products
            };

            return View(homeViewModel);
        }
    }
}