using SportStore.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.Repository.ISportStoreRepo
{
    public interface IUserRepo
    {
        Task<User> GetUserByIdAsync(Guid UserId);
        Task<IEnumerable<User>> GetCompaniesAsync();
        Task AddCompanyAsync(User User);
        Task UpdateCompanyAsync(User User);
        Task RemoveCompanyAsync(Guid UserId);
    }
}
