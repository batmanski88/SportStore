using SportStore.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.Repository.ISportStoreRepo
{
    public interface ICategoryRepo
    {
        Task<Category> GetCategoryByIdAsync(Guid CategoryId);
        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task AddCategoryAsync(Category Category);
        Task UpdateCategoryAsync(Category Category);
        Task RemoveCategoryAsync(Guid CategoryId);
    }
}
