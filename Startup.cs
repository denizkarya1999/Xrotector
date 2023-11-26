using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xrocter.Controllers;
using Xrocter.Models;
using Xrocter.Views;

namespace Xrocter
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private async void createAccountButton_ClickAsync(object sender, EventArgs e)
        {
            // Gather user input
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            //Use EFcore to add the user
            using (var dbContext = new AppDbContext())
            {
                //Create a Central Controller instance
                CentralController centralController = new CentralController(dbContext);

                //Trigger the function
                await centralController.CreateUserAccount(firstName, lastName, email, password);
            }

            //Reset buttons
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            passwordTextBox.Text = "";

            //Show message
            MessageBox.Show("The account has been successfully created", "Success");
        }

        private async void login_Button_Click(object sender, EventArgs e)
        {
            string email = Email_Login_Textbox.Text;
            string password = Password_Login_Textbox.Text;

            //Use EFcore to login
            using (var dbContext = new AppDbContext())
            {
                //Create a Central Controller instance
                CentralController centralController = new CentralController(dbContext);

                //Trigger the function
                await centralController.Authenticate(email, password);
            }

            //Reset buttons
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }

        private async void PasswordRecoveryLink_LinkClickedAsync(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Get the user`s email
            string email = Email_Login_Textbox.Text;

            //Use EFcore to login
            using (var dbContext = new AppDbContext())
            {
                // Create an instance of userAccountController
                UserAccountController user_Controller = new UserAccountController(dbContext);

                // Get the user by Email
                UserAccount targetUser = await user_Controller.GetUserByEmailAsync(email);

                // Initialize classes
                PasswordRecoveryWizard passwordRecovery = new PasswordRecoveryWizard();

                // Pass the parameter
                passwordRecovery.SetLoggedInUser(targetUser);

                // Show program
                passwordRecovery.Show();
            }
        }
    }
}
