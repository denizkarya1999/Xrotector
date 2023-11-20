using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xrocter.Models;
using Xrocter.Views;

namespace Xrocter.Controllers.Processes.AuthenticationProcess
{
    public class LoginApp
    {
        //Create instances that will be used for this function
        private Authenticator loginSession;
        private UserAccount userAccount;

        //Constructor
        protected LoginApp()
        {
        }

        //Method to sign in
        public static void SignIn(Authenticator loginSession, UserAccount userAccount, string Password)
        {
            //Password matches generate a form with a new user account - Further upgrade shall be performed
            if(userAccount.Email != null && userAccount.Password == Password)
            {
                // Initialize classes
                MainProgram mainProgram = new MainProgram();

                // Pass the parameter
                mainProgram.SetLoggedInUser(userAccount);

                // Show a success message
                MessageBox.Show("Login was successful.");

                // Trigger main program
                mainProgram.Show();
                
            } else
            {
                // Show a fail message
                MessageBox.Show("Either the email or password you entered is invalid. Please try again.");
            }
        }
    }
}
