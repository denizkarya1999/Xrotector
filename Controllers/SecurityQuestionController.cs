using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xrocter.Models;

namespace Xrocter.Controllers
{
    public class SecurityQuestionController
    {
        // Database context
        private readonly AppDbContext _appDBContext;

        // Constructor injecting the database context
        public SecurityQuestionController(AppDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        // Retrieve all security questions asynchronously
        public async Task<List<SecurityQuestion>> GetAllSecurityQuestionsAsync()
        {
            return await _appDBContext.SecurityQuestions.ToListAsync();
        }

        // Retrieve security question by ID asynchronously
        public async Task<SecurityQuestion> GetSecurityQuestionByIdAsync(Guid id)
        {
            return await _appDBContext.SecurityQuestions.FindAsync(id);
        }

        // Add a new security question asynchronously
        public async Task<bool> AddSecurityQuestionAsync(SecurityQuestion securityQuestion)
        {
            await _appDBContext.SecurityQuestions.AddAsync(securityQuestion);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Update an existing security question asynchronously
        public async Task<bool> UpdateSecurityQuestionAsync(SecurityQuestion securityQuestion)
        {
            _appDBContext.SecurityQuestions.Update(securityQuestion);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Delete an existing security question asynchronously
        public async Task<bool> DeleteSecurityQuestionAsync(Guid id)
        {
            var securityQuestion = await _appDBContext.SecurityQuestions.FindAsync(id);
            if (securityQuestion == null)
            {
                return false;
            }

            _appDBContext.SecurityQuestions.Remove(securityQuestion);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }
}