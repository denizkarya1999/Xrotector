using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xrocter.Models;
using Xrocter.Models.Vault_Models.ID;

namespace Xrocter.Controllers.VaultControllers.IDControllers
{
    public class LocalIdController
    {
        // Database context
        private readonly AppDbContext _appDBContext;

        // Constructor injecting the database context
        public LocalIdController(AppDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        // Retrieve all local IDs asynchronously
        public async Task<List<LocalId>> GetAllLocalIdsAsync()
        {
            return await _appDBContext.LocalIds.ToListAsync();
        }

        // Retrieve local ID by ID asynchronously
        public async Task<LocalId> GetLocalIdByIdAsync(Guid id)
        {
            return await _appDBContext.LocalIds.FindAsync(id);
        }

        // Add a new local ID asynchronously
        public async Task<bool> AddLocalIdAsync(LocalId localId)
        {
            await _appDBContext.LocalIds.AddAsync(localId);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Update an existing local ID asynchronously
        public async Task<bool> UpdateLocalIdAsync(LocalId localId)
        {
            _appDBContext.LocalIds.Update(localId);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Delete an existing local ID asynchronously
        public async Task<bool> DeleteLocalIdAsync(Guid id)
        {
            var localId = await _appDBContext.LocalIds.FindAsync(id);
            if (localId == null)
            {
                return false;
            }

            _appDBContext.LocalIds.Remove(localId);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }
}