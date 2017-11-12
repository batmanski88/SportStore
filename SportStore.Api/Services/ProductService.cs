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
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;
        private readonly IMapper _mapper;

        public ProductService(IProductRepo productRepo, IMapper mapper)
        {
            _productRepo = productRepo;
            _mapper = mapper;
        }

        public async Task<List<ProductViewModel>> GetProductsAsync()
        {
            var products = await _productRepo.GetProductsAsync();
            return _mapper.Map<List<ProductViewModel>>(products);
        }
    }
}