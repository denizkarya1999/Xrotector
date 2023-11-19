using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xrocter.Models;

namespace Xrocter.Controllers
{
    public class CentralController
    {
        // Class instance
        private readonly AppDbContext _dbContext;

        // Class constructor
        public CentralController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Method to create a user account
        public async Task CreateUserAccount(string FirstName, string LastName, string Email, string Password)
        {
            //Generate two ids
            Guid UAID = Guid.NewGuid();
            Guid VAID = Guid.NewGuid();

            // Create a user account and a vault
            UserAccount newUserAccount = new UserAccount() {
                UserId = UAID,
                Name = FirstName,
                Surname = LastName,
                Email = Email,
                Password = Password,
                VaultId = VAID
            };
            Vault newvault = new Vault()
            {
                VaultId = VAID,
                Name = "Vault for " + newUserAccount.Name,
                Lock = false,
                Mask = false,
                UserId = UAID
            };

            // Create an instance of userAccountController
            UserAccountController user_Controller = new UserAccountController(_dbContext);
            VaultController vault_Controller = new VaultController(_dbContext);

            // Add the user and vault to system
            await vault_Controller.AddVaultAsync(newvault);
            await user_Controller.AddUserAsync(newUserAccount);
        }

    }
}
