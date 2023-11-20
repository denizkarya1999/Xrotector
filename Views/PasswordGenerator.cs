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

namespace Xrocter.Views
{
    public partial class PasswordGenerator : Form
    {
        private UserAccount loggedInUser; // Store the logged-in user here

        // Method to set the logged-in user
        public void SetLoggedInUser(UserAccount user)
        {
            loggedInUser = user;
        }

        public PasswordGenerator()
        {
            InitializeComponent();
        }

        private async void generateButton_Click(object sender, EventArgs e)
        {
            // Create an instance for use
            string userSelection = selectionList.SelectedItem.ToString();

            //Use EFcore to login
            using (var dbContext = new AppDbContext())
            {
                //Create a Central Controller instance
                CentralController centralController = new CentralController(dbContext);

                await centralController.BuildStrongPassword(loggedInUser.UserId, userSelection);
            }
        }
    }
}
