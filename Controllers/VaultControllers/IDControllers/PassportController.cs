using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xrocter.Models;
using Xrocter.Models.Vault_Models.ID;

namespace Xrocter.Controllers.VaultControllers.IDControllers
{
    public class PassportController
    {
        // Database context
        private readonly AppDbContext _appDBContext;

        // Constructor injecting the database context
        public PassportController(AppDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        // Retrieve all passports asynchronously
        public async Task<List<Passport>> GetAllPassportsAsync()
        {
            return await _appDBContext.Passports.ToListAsync();
        }

        // Retrieve passport by ID asynchronously
        public async Task<Passport> GetPassportByIdAsync(Guid id)
        {
            return await _appDBContext.Passports.FindAsync(id);
        }

        // Add a new passport asynchronously
        public async Task<bool> AddPassportAsync(Passport passport)
        {
            await _appDBContext.Passports.AddAsync(passport);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Update an existing passport asynchronously
        public async Task<bool> UpdatePassportAsync(Passport passport)
        {
            _appDBContext.Passports.Update(passport);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Delete an existing passport asynchronously
        public async Task<bool> DeletePassportAsync(Guid id)
        {
            var passport = await _appDBContext.Passports.FindAsync(id);
            if (passport == null)
            {
                return false;
            }

            _appDBContext.Passports.Remove(passport);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }
}