using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SportStore.Api.ViewModels;
using SportStore.Repository.ISportStoreRepo;
using AutoMapper;
using System.IO;
using System.Web.Mvc;
using SportStore.Repository.Models;
using System.Web.Hosting;

namespace SportStore.Api.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _categoryRepo;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepo categoryRepo, IMapper mapper)
        {
            _categoryRepo = categoryRepo;
            _mapper = mapper;
        }

        public async Task AddCategory(CategoryViewModel model, HttpPostedFileBase file)
        {
            string _path;
                
                if(file.ContentLength > 0)
                {
                    model.IconFileName = Path.GetFileName(file.FileName);
                    _path = Path.Combine(HostingEnvironment.MapPath("~/Content/Icons"), model.IconFileName);
                    file.SaveAs(_path);
                }
            
            model.CategoryId = Guid.NewGuid();

            var category = _mapper.Map<CategoryViewModel, Category>(model);

            await _categoryRepo.AddCategoryAsync(category);
        }

        public async Task<List<CategoryViewModel>> GetCategoriesAsync()
        {
            var categories = await _categoryRepo.GetCategoriesAsync();
            return _mapper.Map<List<CategoryViewModel>>(categories);
        }
    }
}