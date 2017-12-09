using SportStore.Repository.ISportStoreRepo;
using System;
using System.Collections.Generic;
using System.Text;
using SportStore.Repository.Models;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SportStore.Repository.SportStoreRepo
{
    public class UserRepo : IUserRepo
    {
        private readonly IStoreContext _context;

        public UserRepo(IStoreContext context)
        {
            _context = context;
        }

        public async Task AddUserAsync(User User)
        {
            _context.Users.Add(User);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserByEmailAsync(string Email)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Email == Email);
        }

        public async Task<User> GetUserByIdAsync(Guid UserId)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.UserId == UserId);
        }

        public async Task RemoveUserAsync(Guid UserId)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserId == UserId);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }


        public async Task UpdateUserAsync(User User)
        {
            _context.Users.Add(User);
            await _context.SaveChangesAsync();
        }

    }
}
