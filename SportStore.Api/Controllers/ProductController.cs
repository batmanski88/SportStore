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
    public class ProductController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public ProductController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> AddProduct()
        {

            var model = new AddProductViewModel();
            await _productService.ChangeViewModel(model);
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct(AddProductViewModel model, HttpPostedFileBase file)
        {
            if(ModelState.IsValid)
            {
                if(model.Count > 0)
                {
                    model.Available = true;
                }
                await _productService.AddProductAsync(model, file);
                ViewBag.Message = "Pomyślnie dodano produkt";
                ModelState.Clear();
                return View(model);
            }

            return View();
        }

      
    }
}