using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xrocter.Models;

namespace Xrocter.Controllers
{
    public class VaultController
    {
        // Database context
        private readonly AppDbContext _appDBContext;

        // Constructor injecting the database context
        public VaultController(AppDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        // Retrieve all vaults asynchronously
        public async Task<List<Vault>> GetAllVaultsAsync()
        {
            return await _appDBContext.Vaults.ToListAsync();
        }

        // Retrieve vault by ID asynchronously
        public async Task<Vault> GetVaultByIdAsync(Guid? id)
        {
            return await _appDBContext.Vaults.FindAsync(id);
        }

        // Add a new vault asynchronously
        public async Task<bool> AddVaultAsync(Vault vault)
        {
            await _appDBContext.Vaults.AddAsync(vault);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Update an existing vault asynchronously
        public async Task<bool> UpdateVaultAsync(Vault vault)
        {
            _appDBContext.Vaults.Update(vault);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Delete an existing vault asynchronously
        public async Task<bool> DeleteVaultAsync(Vault vault)
        {
            _appDBContext.Vaults.Remove(vault);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }
}