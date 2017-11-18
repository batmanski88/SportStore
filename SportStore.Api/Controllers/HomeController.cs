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
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public HomeController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        // GET: Home
        public async Task<ActionResult> Index()
        {
            var categories = await _categoryService.GetCategoriesAsync();
            var products = await _productService.GetProductsAsync();
            var sixproducts = products.OrderBy(p => Guid.NewGuid()).Take(6).ToList();

            var homeViewModel = new HomeViewModel
            {
                Categories = categories,
                Products = sixproducts
            };

            return View(homeViewModel);
        }
    }
}