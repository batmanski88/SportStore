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
        Task<User> GetUserByEmailAsync(string Email);
        Task<IEnumerable<User>> GetUsersAsync();
        Task AddUserAsync(User User);
        Task UpdateUserAsync(User User);
        Task RemoveUserAsync(Guid UserId);
    }
}
