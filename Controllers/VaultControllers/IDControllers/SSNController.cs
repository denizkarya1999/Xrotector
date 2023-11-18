using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xrocter.Models;
using Xrocter.Models.Vault_Models.ID;

namespace Xrocter.Controllers.VaultControllers.IDControllers
{
    public class SSNController
    {
        // Database context
        private readonly AppDbContext _appDBContext;

        // Constructor injecting the database context
        public SSNController(AppDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        // Retrieve all SSNs asynchronously
        public async Task<List<SSN>> GetAllSSNsAsync()
        {
            return await _appDBContext.SSNs.ToListAsync();
        }

        // Retrieve SSN by ID asynchronously
        public async Task<SSN> GetSSNByIdAsync(Guid id)
        {
            return await _appDBContext.SSNs.FindAsync(id);
        }

        // Add a new SSN asynchronously
        public async Task<bool> AddSSNAsync(SSN ssn)
        {
            await _appDBContext.SSNs.AddAsync(ssn);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Update an existing SSN asynchronously
        public async Task<bool> UpdateSSNAsync(SSN ssn)
        {
            _appDBContext.SSNs.Update(ssn);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Delete an existing SSN asynchronously
        public async Task<bool> DeleteSSNAsync(Guid id)
        {
            var ssn = await _appDBContext.SSNs.FindAsync(id);
            if (ssn == null)
            {
                return false;
            }

            _appDBContext.SSNs.Remove(ssn);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }
}