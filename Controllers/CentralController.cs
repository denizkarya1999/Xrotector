using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xrocter.Models;
using Xrocter.Controllers.Processes;
using Xrocter.Controllers.Processes.AuthenticationProcess;
using Xrocter.Controllers.Processes.PasswordGenerationProcess;
using Xrocter.Controllers.Processes.MaskProcess;
using System.Windows.Forms;
using Xrocter.Controllers.Processes.PasswordRecoveryProcess;

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

        // Method to invoke authentication process
        public async Task<UserAccount> Authenticate(string userEmail,string password)
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
            } else {
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
            if(typeOfPassword == "Personal")
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
            if(targetVault.Mask == true)
            {
                // Show a message
                MessageBox.Show("We successfully masked your vault. Your data is under our protection.");
                return targetVault;
            } else
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
    }
}
