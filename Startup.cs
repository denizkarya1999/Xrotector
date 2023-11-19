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
    }
}
