using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SportStore.Api.ViewModels;
using SportStore.Repository.ISportStoreRepo;
using AutoMapper;

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
        public async Task<List<CategoryViewModel>> GetCategoriesAsync()
        {
            var categories = await _categoryRepo.GetCategoriesAsync();
            return _mapper.Map<List<CategoryViewModel>>(categories);
        }
    }
}