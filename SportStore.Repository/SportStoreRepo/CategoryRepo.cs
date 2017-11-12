using SportStore.Repository.ISportStoreRepo;
using System;
using System.Collections.Generic;
using System.Text;
using SportStore.Repository.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SportStore.Repository.SportStoreRepo
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly IStoreContext _context;

        public CategoryRepo(IStoreContext context)
        {
            _context = context;
        }


        public async Task AddCategoryAsync(Category Category)
        {
            _context.Categories.Add(Category);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(Guid CategoryId)
        {
            return await _context.Categories.FirstOrDefaultAsync(x => x.CategoryId == CategoryId);
        }

        public async Task RemoveCategoryAsync(Guid CategoryId)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x => x.CategoryId == CategoryId);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategoryAsync(Category Category)
        {
            _context.Categories.Update(Category);
            await _context.SaveChangesAsync();
        }
    }
}
