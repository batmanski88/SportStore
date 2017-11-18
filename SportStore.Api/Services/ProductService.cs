using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SportStore.Api.ViewModels;
using SportStore.Repository.ISportStoreRepo;
using AutoMapper;
using System.Web.Mvc;
using System.IO;
using System.Web.Hosting;
using SportStore.Repository.Models;

namespace SportStore.Api.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;
        private readonly ICategoryRepo _categoryRepo;
        private readonly IMapper _mapper;

        public ProductService(IProductRepo productRepo, IMapper mapper, ICategoryRepo categoryRepo)
        {
            _productRepo = productRepo;
            _categoryRepo = categoryRepo;
            _mapper = mapper;
        }

        public async Task<List<ProductViewModel>> GetProductsAsync()
        {
            var products = await _productRepo.GetProductsAsync();
            return _mapper.Map<List<ProductViewModel>>(products);
        }

        public async Task AddProductAsync(AddProductViewModel model, HttpPostedFileBase file)
        {
            await ChangeViewModel(model);
            try
            {
                if(file.ContentLength > 0)
                {
                    model.FileName = Path.GetFileName(file.FileName);
                    string _path = Path.Combine(HostingEnvironment.MapPath("~/Content/Products"), model.FileName);
                    file.SaveAs(_path);
                }
            }
            catch
            {
                throw new Exception("Nie udało się dodać pliku");
            }

            model.ProductId = Guid.NewGuid();
            var product = _mapper.Map<AddProductViewModel, Product>(model);
            await _productRepo.AddProductAsync(product);
        }

        public async Task ChangeViewModel(AddProductViewModel model)
        {
            var categories = await _categoryRepo.GetCategoriesAsync();
            model.Categories = new SelectList(categories, "CategoryId", "Name");
            
        }
    }
}