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
using Xrocter.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace Xrocter.Views
{
    public partial class MainProgram : Form
    {

        private System.Windows.Forms.Timer timer;
        private UserAccount loggedInUser; // Store the logged-in user here
        private Vault loggedInUserVault; // Store the logged-in user vault here
        private bool userChoice = false; // Define the variable at the class level

        // Method to set the logged-in user
        public async Task SetLoggedInUserAsync(UserAccount user)
        {
            loggedInUser = user;
            await MaskButtonSetup(user);
        }

        public MainProgram()
        {
            InitializeComponent();
        }

        private async void MainProgram_Load(object sender, EventArgs e)
        {
            WelcomeLabel.Text = "Welcome " + loggedInUser.Name;

            //Upon load, login to EF Core
            using (var dbContext = new AppDbContext())
            {
                //Create a Central Controller instance
                CentralController centralController = new CentralController(dbContext);

                //Call the storage management to detect any expiry date problems
                await centralController.PasswordStorageProcess(loggedInUser.UserId, loggedInUserVault.VaultId);
            }

            // Initialize and configure the timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 60000; // 1 minute in milliseconds
            timer.Tick += Timer_Tick;

            // Start the timer
            timer.Start();
        }

        //Mask button setup
        private async Task<Vault> MaskButtonSetup(UserAccount user)
        {
            loggedInUserVault = await InitializeVault(user.VaultId);

            // Setup mask button
            if (loggedInUserVault.Mask == false)
            {
                maskButton.Text = "Mask Vault";
            }
            else
            {
                maskButton.Text = "Unmask Vault";
            }

            return loggedInUserVault;
        }

        //Initialize the vault here
        public async Task<Vault> InitializeVault(Guid? vaultID)
        {
            //Use EFcore to login
            using (var dbContext = new AppDbContext())
            {
                // Create an instance of vault controller
                VaultController vault_Controller = new VaultController(dbContext);

                // Get the vault by ID
                Vault targetVault = await vault_Controller.GetVaultByIdAsync(vaultID);

                return targetVault;
            }
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

        private async void maskButton_Click(object sender, EventArgs e)
        {
            // Toggle the value of userChoice
            userChoice = !userChoice;

            //Use EFcore to start mask process
            using (var dbContext = new AppDbContext())
            {
                //Create a Central Controller instance
                CentralController centralController = new CentralController(dbContext);

                //Trigger the masking process
                await centralController.MaskProcess(loggedInUserVault.VaultId, userChoice);

                //Setup the button
                MaskButtonSetup(loggedInUser);
            }
        }

        private void aboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string creators = "Creators: Deniz, Mohammad, Yahya";
            string version = "Version: 1.0 Beta";

            MessageBox.Show($"{creators}\n{version}", "About Xrocter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            timer.Stop();

            // Ask for confirmation before closing the form
            DialogResult result = MessageBox.Show("The form will be closed due to inactivity. Do you want to continue?", "Inactive", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Check user's choice
            if (result == DialogResult.Yes)
            {
                // Restart the timer if the user wants to continue
                timer.Start();
            }
            else
            {
                // Close the form if the user chooses not to continue
                this.Close();
            }
        }
    }
}
