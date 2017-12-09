using SportStore.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SportStore.Api.Services
{
    public interface IAccountService
    {
        Task<IEnumerable<UserViewModel>> GetUsersAsync();
        Task<UserViewModel> GetUser(string Email);
        Task Register(RegisterViewModel model);
        Task<string> GetCustomUserRoleAsync(string email);
        Task Login(LoginViewModel model);
    }
}