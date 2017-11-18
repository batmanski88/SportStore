using SportStore.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SportStore.Api.Services
{
    public interface IProductService
    {
        Task<List<ProductViewModel>> GetProductsAsync();
        Task AddProductAsync(AddProductViewModel model, HttpPostedFileBase file);
        Task ChangeViewModel(AddProductViewModel model);
    }
}
