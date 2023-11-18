using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xrocter.Models;

namespace Xrocter.Controllers.VaultControllers
{
    public class SecurityNoteController
    {
        // Database context
        private readonly AppDbContext _appDBContext;

        // Constructor injecting the database context
        public SecurityNoteController(AppDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        // Retrieve all security notes asynchronously
        public async Task<List<SecurityNote>> GetAllSecurityNotesAsync()
        {
            return await _appDBContext.SecurityNotes.ToListAsync();
        }

        // Retrieve security note by ID asynchronously
        public async Task<SecurityNote> GetSecurityNoteByIdAsync(Guid id)
        {
            return await _appDBContext.SecurityNotes.FindAsync(id);
        }

        // Add a new security note asynchronously
        public async Task<bool> AddSecurityNoteAsync(SecurityNote securityNote)
        {
            await _appDBContext.SecurityNotes.AddAsync(securityNote);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Update an existing security note asynchronously
        public async Task<bool> UpdateSecurityNoteAsync(SecurityNote securityNote)
        {
            _appDBContext.SecurityNotes.Update(securityNote);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Delete an existing security note asynchronously
        public async Task<bool> DeleteSecurityNoteAsync(Guid id)
        {
            var securityNote = await _appDBContext.SecurityNotes.FindAsync(id);
            if (securityNote == null)
            {
                return false;
            }

            _appDBContext.SecurityNotes.Remove(securityNote);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }
}