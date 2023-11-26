using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xrocter.Models;
using Xrocter.Controllers.VaultControllers;
using Xrocter.Controllers.VaultControllers.IDControllers;
using Xrocter.Controllers.Processes;
using Xrocter.Controllers.Processes.AuthenticationProcess;
using Xrocter.Controllers.Processes.PasswordGenerationProcess;
using Xrocter.Controllers.Processes.MaskProcess;
using System.Windows.Forms;
using Xrocter.Controllers.Processes.PasswordRecoveryProcess;
using Xrocter.Services.PasswordManagement;
using Xrocter.Vault_Models.ID;
using Xrocter.Models.Vault_Models.ID;

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
            UserAccount newUserAccount = new UserAccount()
            {
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

        // Method to invoke authentication process
        public async Task<UserAccount> Authenticate(string userEmail, string password)
        {
            // Create an instance of userAccountController
            UserAccountController user_Controller = new UserAccountController(_dbContext);

            // Generate a user account
            UserAccount newUser = await user_Controller.GetUserByEmailAsync(userEmail);

            // Generate a login session
            Authenticator loginSession = Authenticator.generateLoginSession();

            //If the login session is not null, invoke the login process
            if (loginSession != null)
            {
                LoginApp.SignIn(loginSession, newUser, password);
                return newUser;
            }
            else
            {
                MessageBox.Show("You are already logged in. Please sign out and try again.");
                return null;
            }
        }

        // Method to invoke password building process
        public async Task<UserAccount> BuildStrongPassword(Guid userAccountID, string typeOfPassword)
        {
            // Create an instance of userAccountController
            UserAccountController user_Controller = new UserAccountController(_dbContext);

            // Get the user by ID
            UserAccount targetUser = await user_Controller.GetUserByIdAsync(userAccountID);

            // Create an instance for PasswordMaster
            PasswordMaster masterX = new PasswordMaster();

            // Change the user`s password
            if (typeOfPassword == "Personal")
            {
                // Generate an instance for Personal Password
                PasswordBuilder newPersonalPassword = new PersonalPassword();

                // Invoke builder process there
                masterX.generatePassword(newPersonalPassword);

                // Get the new password
                string finalPassword = newPersonalPassword.GetPassword();

                // Assign the new password
                targetUser.Password = finalPassword;

                // Update the password on database
                await user_Controller.UpdateUserAsync(targetUser);

                // Notify the user
                MessageBox.Show("Your current password is: " + targetUser.Password);

                return targetUser;
            }
            else if (typeOfPassword == "Enterprise")
            {
                // Generate an instance for Enterprise Password
                PasswordBuilder newEnterprisePassword = new EnterprisePassword();

                // Invoke builder process there
                masterX.generatePassword(newEnterprisePassword);

                // Get the new password
                string finalPassword = newEnterprisePassword.GetPassword();

                // Assign the new password
                targetUser.Password = finalPassword;

                // Update the password on database
                await user_Controller.UpdateUserAsync(targetUser);

                // Notify the user
                MessageBox.Show("Your current password is: " + targetUser.Password);

                return targetUser;
            }
            else
            {
                MessageBox.Show("This type of password cannot be generated");
                return null;
            }
        }

        // Method to invoke masking process
        public async Task<Vault> MaskProcess(Guid vaultID, bool userChoice)
        {
            // Create an instance of vault controller
            VaultController vault_Controller = new VaultController(_dbContext);

            // Get the vault by ID
            Vault targetVault = await vault_Controller.GetVaultByIdAsync(vaultID);

            // Create an instance of Mask
            IMask processMask = new MaskProxy(userChoice);

            // Assign the value using the program
            targetVault.Mask = processMask.IsMasked;

            // Update the mask on the database
            await vault_Controller.UpdateVaultAsync(targetVault);

            // Take actions based on the result of the process
            if (targetVault.Mask == true)
            {
                // Show a message
                MessageBox.Show("We successfully masked your vault. Your data is under our protection.");
                return targetVault;
            }
            else
            {
                // Show a message
                MessageBox.Show("We successfully unmasked your vault. Please handle your data in care.");
                return null;
            }
        }

        //Method to invoke Password Recovery process
        public async Task<SecurityQuestion> PasswordRecoveryProcess(Guid userAccountID, string[] userAnswers)
        {
            // Create an instance of userAccountController
            UserAccountController user_Controller = new UserAccountController(_dbContext);

            // Get the user by ID
            UserAccount targetUser = await user_Controller.GetUserByIdAsync(userAccountID);

            // Create an instance of Security Question Controller
            SecurityQuestionController _security_Question_Controller = new SecurityQuestionController(_dbContext);

            // Get all security questions by user ID
            List<SecurityQuestion> securityQuestions = await _security_Question_Controller.GetAllSecurityQuestionsByUserIDAsync(userAccountID);

            if (securityQuestions.Count >= 3) // Assuming you have at least three questions
            {
                RecoveryAssistant questionOne = new QuestionOne(securityQuestions[0].Question, userAnswers[0]);
                RecoveryAssistant questionTwo = new QuestionTwo(securityQuestions[1].Question, userAnswers[1]);
                RecoveryAssistant questionThree = new QuestionThree(securityQuestions[2].Question, userAnswers[2]);

                bool answerOne = await questionOne.RecoverPasswordAsync(securityQuestions[0].Answer);
                bool answerTwo = await questionTwo.RecoverPasswordAsync(securityQuestions[1].Answer);
                bool answerThree = await questionThree.RecoverPasswordAsync(securityQuestions[2].Answer);

                // Handle the password recovery process based on the answers received
                // For example:
                if (answerOne && answerTwo && answerThree)
                {
                    // Show a messagebox
                    MessageBox.Show("We reseted your password as 12345. Please generate a master password immediately.");

                    // Set new password for the user
                    targetUser.Password = "12345";

                    // Update the password on database
                    await user_Controller.UpdateUserAsync(targetUser);
                }
                else
                {
                    // Show a messagebox
                    MessageBox.Show("Unfortunately we cannot reset your password. Please create another account.");
                }
            }
            return null;
        }

        // Method to perform Password Storage Process
        public async Task<Vault> PasswordStorageProcess(Guid userAccountID, Guid vaultID)
        {
            // Create an instance of userAccountController
            UserAccountController user_Controller = new UserAccountController(_dbContext);

            // Get the user by ID
            UserAccount targetUser = await user_Controller.GetUserByIdAsync(userAccountID);

            // Create an instance of vault controller
            VaultController vault_Controller = new VaultController(_dbContext);

            // Get the vault by ID
            Vault targetVault = await vault_Controller.GetVaultByIdAsync(vaultID);

            // Create controller instances for Drivers License, Passport, SSN and Credit Card
            DriversLicenseController driversLicenseController = new DriversLicenseController(_dbContext);
            PassportController passportController = new PassportController(_dbContext);
            SSNController sSNController = new SSNController(_dbContext);
            CreditCardController creditCardController = new CreditCardController(_dbContext);

            // Initialize specific components (Drivers License, Passport, SSN and Credit Card)
            DriversLicense? driversLicense = await driversLicenseController.GetDriversLicenseByVaultIdAsync(vaultID);
            Passport? passport = await passportController.GetPassportByVaultIdAsync(vaultID);
            SSN? ssn = await sSNController.GetSSNbyVaultIdAsync(vaultID);
            CreditCard? creditCard = await creditCardController.GetCreditCardByVaultIdAsync(vaultID);

            // Check instances of the expiration dates
            DateTime currentDate = DateTime.Today;
            bool? driversLicenseExpirationDate = IsExpirationValid(driversLicense?.ExpiryDate, currentDate);
            bool? passportExpiryDate = IsExpirationValid(passport?.ExpiryDate, currentDate);
            bool? ssnExpiryDate = IsExpirationValid(ssn?.ExpiryDate, currentDate);
            bool? creditCardExpiryDate = IsExpirationValid(creditCard?.ExpiryDate, currentDate);

            // Create a general subject instance
            var Subject = new ConcreteSubject<string>();

            // If the password is weak notify the user
            if (IsWeakPassword(targetUser.Password))
            {
                // Create an instance of PasswordStrengthObserver and attach it to the subject
                var passwordObserver = new PasswordStrengthObserver(Subject, "PasswordObserver");

                //Attach the observer
                Subject.Attach(passwordObserver);

                // Change the state of the subject (password strength)
                Subject.State = "Weak";

                // Update the observer
                passwordObserver.Update(Subject.State);

                // Detach the observer
                Subject.Detach(passwordObserver);
            }

            // Check if any of the expiration dates are null or false
            if ((driversLicenseExpirationDate ?? false) == false ||
                (passportExpiryDate ?? false) == false ||
                (ssnExpiryDate ?? false) == false ||
                (creditCardExpiryDate ?? false) == false) { 
                // Create an instance of ExpirationObserver and attach it to the subject
                var expirationObserver = new ExpirationObserver(Subject, "ExpirationObserver");

                // Attach the observer
                Subject.Attach(expirationObserver);

                // Change the state of the subject (password strength)
                Subject.State = "About to expire or not initialized";

                // Update the observer
                expirationObserver.Update(Subject.State);

                // Detach the observer
                Subject.Detach(expirationObserver);
            }
            return null;
        }

        public bool IsWeakPassword(string password)
        {
            // Check length
            if (password.Length < 8)
            {
                return true; // Password is too short
            }

            // Check complexity (e.g., presence of uppercase, lowercase, digits, and special characters)
            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;
            bool hasSpecialChar = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpperCase = true;
                }
                else if (char.IsLower(c))
                {
                    hasLowerCase = true;
                }
                else if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
                else if (char.IsSymbol(c) || char.IsPunctuation(c))
                {
                    hasSpecialChar = true;
                }
            }

            // Check if all required types of characters are present
            if (!(hasUpperCase && hasLowerCase && hasDigit && hasSpecialChar))
            {
                return true; // Password lacks required complexity
            }

            // Password is considered strong if it passes the above criteria
            return false;
        }

        // Method to check expiration dates
        public bool IsExpirationValid(DateTime? expirationDate, DateTime currentDate)
        {
            if (expirationDate == null)
            {
                // If expiration date is null, it's considered invalid
                return false;
            }

            // Calculate the difference in months between the two dates
            int monthsDifference = ((expirationDate.Value.Year - currentDate.Year) * 12) + expirationDate.Value.Month - currentDate.Month;

            // Check if the difference is greater than or equal to 6 months
            return monthsDifference >= 6;
        }
    }
}
