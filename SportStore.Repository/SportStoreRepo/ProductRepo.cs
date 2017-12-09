using SportStore.Repository.ISportStoreRepo;
using System;
using System.Collections.Generic;
using System.Text;
using SportStore.Repository.Models;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SportStore.Repository.SportStoreRepo
{
    public class ProductRepo : IProductRepo
    {
        private readonly IStoreContext _context;

        public ProductRepo(IStoreContext context)
        {
            _context = context;
        }

        public async Task AddProductAsync(Product Product)
        {
            _context.Products.Add(Product);
            await _context.SaveChangesAsync();
        }

        public async Task<Product> GetProductByIdAsync(Guid ProductId)
        {
            return await _context.Products.FirstOrDefaultAsync(x => x.ProductId == ProductId);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task RemoveProductAsync(Guid ProductId)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.ProductId == ProductId);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProdutcAsync(Product Product)
        {
            _context.Products.Add(Product);
            await _context.SaveChangesAsync();
        }
    }
}
