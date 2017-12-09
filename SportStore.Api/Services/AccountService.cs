using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SportStore.Api.ViewModels;
using SportStore.Repository.ISportStoreRepo;
using AutoMapper;
using SportStore.Repository.Models;
using System.Web.Security;
using System.Security.Claims;
using SportStore.Api.Infrastructure.Security;

namespace SportStore.Api.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUserRepo _userRepo;
        private readonly IMapper _mapper;
        private readonly IEncrypter _encrypter;

        public AccountService(IUserRepo userRepo, IMapper mapper, IEncrypter encrypter)
        {
            _userRepo = userRepo;
            _mapper = mapper;
            _encrypter = encrypter;
        }

        public async Task<UserViewModel> GetUser(string Email)
        {
            var user = await _userRepo.GetUserByEmailAsync(Email);
            if (user == null)
            {
                throw new Exception($"Użytkownik o takim adresie email {Email} nie istnieje");
            }


            return _mapper.Map<UserViewModel>(user);
        }

        public async Task<string> GetCustomUserRoleAsync(string Email)
        {
            var user = await _userRepo.GetUserByEmailAsync(Email);

            return user.Role;
        }

        public async Task<IEnumerable<UserViewModel>> GetUsersAsync()
        {
            var user = await _userRepo.GetUsersAsync();
            return _mapper.Map<IEnumerable<UserViewModel>>(user);
        }

        public async Task Login(LoginViewModel model)
        {
            var user = await _userRepo.GetUserByEmailAsync(model.Email);
            if(user == null)
            {
                throw new Exception($"Użytkownik o takim adresie {model.Email} nie istnieje");
            }

            var hash = _encrypter.GetHash(model.Password, user.Salt);
            model.Role = user.Role;

            if(user.Password == hash)
            {
                var claims = new[]
{
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.Role, user.Role),
                        new Claim("user", user.ToString())
                    };

                var identity = new ClaimsIdentity(claims, "ApplicationCoockie");
                var ctx = HttpContext.Current.Request.GetOwinContext();

                var authManager = ctx.Authentication;

                authManager.SignIn(identity);
            }


        }
        public async Task Register(RegisterViewModel model)
        {
            var user = await _userRepo.GetUserByEmailAsync(model.Email);
            if (user != null)
            {
                throw new Exception($"Użytkownik o takim adresie email {model.Email} już istnieje!");
            }

            var salt = _encrypter.GetSalt(model.Password);
            var hash = _encrypter.GetHash(model.Password, salt);

            
            user = new User(model.UserId, model.UserName, hash, salt, model.Email, "Administrator");
            await _userRepo.AddUserAsync(user);
        }


    }
}