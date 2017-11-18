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
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddCategory(CategoryViewModel model, HttpPostedFileBase file)
        {
            if(ModelState.IsValid)
            {
                await _categoryService.AddCategory(model, file);
                ViewBag.Message = "Pomyślnie dodano kategorie";
                ModelState.Clear();
                return View();
            }

            return View();
        }

        
    }
}