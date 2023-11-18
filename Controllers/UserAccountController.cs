using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xrocter.Models;
using Xrocter.Models.Vault_Models;

namespace Xrocter.Controllers
{
    public class UserAccountController
    {
        // Database context
        private readonly AppDbContext _appDBContext;

        // Constructor injecting the database context
        public UserAccountController(AppDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        // Retrieve all users asynchronously
        public async Task<List<UserAccount>> GetAllUsersAsync()
        {
            return await _appDBContext.UserAccounts.ToListAsync();
        }

        // Retrieve user by ID asynchronously
        public async Task<UserAccount> GetUserByIdAsync(Guid id)
        {
            return await _appDBContext.UserAccounts.FindAsync(id);
        }

        // Retrieve user by name asynchronously
        public async Task<UserAccount> GetUserByNameAsync(string name)
        {
            return await _appDBContext.UserAccounts.FirstOrDefaultAsync(c => c.Name == name);
        }

        // Retrieve user by email asynchronously
        public async Task<UserAccount> GetUserByEmailAsync(string email)
        {
            return await _appDBContext.UserAccounts.FirstOrDefaultAsync(c => c.Email == email);
        }

        // Add a new user asynchronously
        public async Task<bool> AddUserAsync(UserAccount user)
        {
            await _appDBContext.UserAccounts.AddAsync(user);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Update an existing user asynchronously
        public async Task<bool> UpdateUserAsync(UserAccount user)
        {
            _appDBContext.UserAccounts.Update(user);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Delete an existing user asynchronously
        public async Task<bool> DeleteUserAsync(UserAccount user)
        {
            _appDBContext.UserAccounts.Remove(user);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }
}