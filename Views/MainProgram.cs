using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xrocter.Models;

namespace Xrocter.Views
{
    public partial class MainProgram : Form
    {
        private UserAccount loggedInUser; // Store the logged-in user here

        // Method to set the logged-in user
        public void SetLoggedInUser(UserAccount user)
        {
            loggedInUser = user;
        }

        public MainProgram()
        {
            InitializeComponent();
        }

        private void MainProgram_Load(object sender, EventArgs e)
        {
            WelcomeLabel.Text = "Welcome " + loggedInUser.Name;
        }

        private void generatePasswordbutton_Click(object sender, EventArgs e)
        {
            // Initialize classes
            PasswordGenerator passwordGenerator = new PasswordGenerator();

            // Pass the parameter
            passwordGenerator.SetLoggedInUser(loggedInUser);

            // Show program
            passwordGenerator.Show();
        }
    }
}
