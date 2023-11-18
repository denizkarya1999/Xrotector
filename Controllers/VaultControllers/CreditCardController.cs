using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xrocter.Models;

namespace Xrocter.Controllers.VaultControllers
{
    public class CreditCardController
    {
        // Database context
        private readonly AppDbContext _appDBContext;

        // Constructor injecting the database context
        public CreditCardController(AppDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        // Retrieve all credit cards asynchronously
        public async Task<List<CreditCard>> GetAllCreditCardsAsync()
        {
            return await _appDBContext.CreditCards.ToListAsync();
        }

        // Retrieve credit card by card number asynchronously
        public async Task<CreditCard> GetCreditCardByCardNumberAsync(Guid cardNumber)
        {
            return await _appDBContext.CreditCards.FindAsync(cardNumber);
        }

        // Add a new credit card asynchronously
        public async Task<bool> AddCreditCardAsync(CreditCard creditCard)
        {
            await _appDBContext.CreditCards.AddAsync(creditCard);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Update an existing credit card asynchronously
        public async Task<bool> UpdateCreditCardAsync(CreditCard creditCard)
        {
            _appDBContext.CreditCards.Update(creditCard);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Delete an existing credit card asynchronously
        public async Task<bool> DeleteCreditCardAsync(Guid cardNumber)
        {
            var creditCard = await _appDBContext.CreditCards.FindAsync(cardNumber);
            if (creditCard == null)
            {
                return false;
            }

            _appDBContext.CreditCards.Remove(creditCard);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }
}