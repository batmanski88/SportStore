using SportStore.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.Repository.ISportStoreRepo
{
    public interface IProductRepo
    {
        Task<Product> GetProductByIdAsync(Guid ProductId);
        Task<IEnumerable<Product>> GetProductsAsync();
        Task AddProductAsync(Product Product);
        Task UpdateProdutcAsync(Product Product);
        Task RemoveProductAsync(Guid ProductId);
    }
}
