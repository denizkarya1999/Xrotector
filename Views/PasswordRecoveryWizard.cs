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

namespace Xrocter.Views
{
    public partial class PasswordRecoveryWizard : Form
    {
        private UserAccount loggedInUser; // Store the logged-in user here

        public PasswordRecoveryWizard()
        {
            InitializeComponent();
        }

        // Method to set the logged-in user
        public void SetLoggedInUser(UserAccount user)
        {
            loggedInUser = user;
        }

        private async void PasswordRecoveryWizard_LoadAsync(object sender, EventArgs e)
        {
            //Use EFcore to login
            using (var dbContext = new AppDbContext())
            {
                // Create an instance of Security Question Controller
                SecurityQuestionController _security_Question_Controller = new SecurityQuestionController(dbContext);

                // Get all security questions by user ID
                List<SecurityQuestion> securityQuestions = await _security_Question_Controller.GetAllSecurityQuestionsByUserIDAsync(loggedInUser.UserId);

                if (securityQuestions.Count >= 3) // Assuming you have at least three questions
                {
                    // Assign to the labels
                    questionOne.Text = securityQuestions[0].Question;
                    QuestionTwo.Text = securityQuestions[1].Question;
                    QuestionThree.Text = securityQuestions[2].Question;
                }
            }
        }

        private async void verifyButton_Click(object sender, EventArgs e)
        {
            //Create a variable for user answers
            string[] userAnswers = new string[3];

            // Assign user answers to an array
            userAnswers[0] = answerOnetextBox.Text;
            userAnswers[1] = answerTwotextBox.Text;
            userAnswers[2] = answerThreeTextbox.Text;

            //Use EFcore to login
            using (var dbContext = new AppDbContext())
            {
                //Create a Central Controller instance
                CentralController centralController = new CentralController(dbContext);

                //Trigger PasswordRecoveryMethod from centralController
                await centralController.PasswordRecoveryProcess(loggedInUser.UserId, userAnswers);
            }

            //Close the form at the end
            this.Close();
        }
    }
}
