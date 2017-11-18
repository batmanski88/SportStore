using SportStore.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SportStore.Api.Controllers
{
    public class StoreController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public StoreController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }


        // GET: Store
        public async Task<ActionResult> ProductList(string currentCategory)
        {
            var categories = await _categoryService.GetCategoriesAsync();
            var products = await _productService.GetProductsAsync();

            var category = categories.Where(c => c.Name.ToUpper() == currentCategory.ToUpper()).Single();
            var productsByCat = products.Where(x => x.CategoryId == category.CategoryId);

            return View(productsByCat);
        }
    }
}