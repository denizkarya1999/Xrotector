using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xrocter.Models;

namespace Xrocter.Controllers.VaultControllers
{
    public class LoginController
    {
        // Database context
        private readonly AppDbContext _appDBContext;

        // Constructor injecting the database context
        public LoginController(AppDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        // Retrieve all logins asynchronously
        public async Task<List<Login>> GetAllLoginsAsync()
        {
            return await _appDBContext.Login_Credentails.ToListAsync();
        }

        // Retrieve login by ID asynchronously
        public async Task<Login> GetLoginByIdAsync(Guid id)
        {
            return await _appDBContext.Login_Credentails.FindAsync(id);
        }

        // Add a new login asynchronously
        public async Task<bool> AddLoginAsync(Login login)
        {
            await _appDBContext.Login_Credentails.AddAsync(login);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Update an existing login asynchronously
        public async Task<bool> UpdateLoginAsync(Login login)
        {
            _appDBContext.Login_Credentails.Update(login);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Delete an existing login asynchronously
        public async Task<bool> DeleteLoginAsync(Guid id)
        {
            var login = await _appDBContext.Login_Credentails.FindAsync(id);
            if (login == null)
            {
                return false;
            }

            _appDBContext.Login_Credentails.Remove(login);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }
}