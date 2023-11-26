namespace Xrocter.Views
{
    partial class PasswordRecoveryWizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordRecoveryWizard));
            questionOne = new Label();
            answerOnetextBox = new TextBox();
            answerTwotextBox = new TextBox();
            QuestionTwo = new Label();
            answerThreeTextbox = new TextBox();
            QuestionThree = new Label();
            verifyButton = new Button();
            SuspendLayout();
            // 
            // questionOne
            // 
            questionOne.AutoSize = true;
            questionOne.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            questionOne.Location = new Point(12, 23);
            questionOne.Name = "questionOne";
            questionOne.Size = new Size(102, 21);
            questionOne.TabIndex = 0;
            questionOne.Text = "QuestionOne";
            // 
            // answerOnetextBox
            // 
            answerOnetextBox.BorderStyle = BorderStyle.FixedSingle;
            answerOnetextBox.Location = new Point(12, 55);
            answerOnetextBox.Name = "answerOnetextBox";
            answerOnetextBox.Size = new Size(819, 23);
            answerOnetextBox.TabIndex = 1;
            // 
            // answerTwotextBox
            // 
            answerTwotextBox.BorderStyle = BorderStyle.FixedSingle;
            answerTwotextBox.Location = new Point(12, 126);
            answerTwotextBox.Name = "answerTwotextBox";
            answerTwotextBox.Size = new Size(819, 23);
            answerTwotextBox.TabIndex = 3;
            // 
            // QuestionTwo
            // 
            QuestionTwo.AutoSize = true;
            QuestionTwo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionTwo.Location = new Point(12, 94);
            QuestionTwo.Name = "QuestionTwo";
            QuestionTwo.Size = new Size(101, 21);
            QuestionTwo.TabIndex = 2;
            QuestionTwo.Text = "QuestionTwo";
            // 
            // answerThreeTextbox
            // 
            answerThreeTextbox.BorderStyle = BorderStyle.FixedSingle;
            answerThreeTextbox.Location = new Point(12, 205);
            answerThreeTextbox.Name = "answerThreeTextbox";
            answerThreeTextbox.Size = new Size(819, 23);
            answerThreeTextbox.TabIndex = 5;
            // 
            // QuestionThree
            // 
            QuestionThree.AutoSize = true;
            QuestionThree.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionThree.Location = new Point(12, 173);
            QuestionThree.Name = "QuestionThree";
            QuestionThree.Size = new Size(112, 21);
            QuestionThree.TabIndex = 4;
            QuestionThree.Text = "QuestionThree";
            // 
            // verifyButton
            // 
            verifyButton.Location = new Point(372, 243);
            verifyButton.Name = "verifyButton";
            verifyButton.Size = new Size(97, 36);
            verifyButton.TabIndex = 6;
            verifyButton.Text = "Verify";
            verifyButton.UseVisualStyleBackColor = true;
            verifyButton.Click += verifyButton_Click;
            // 
            // PasswordRecoveryWizard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(843, 291);
            Controls.Add(verifyButton);
            Controls.Add(answerThreeTextbox);
            Controls.Add(QuestionThree);
            Controls.Add(answerTwotextBox);
            Controls.Add(QuestionTwo);
            Controls.Add(answerOnetextBox);
            Controls.Add(questionOne);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "PasswordRecoveryWizard";
            Text = "Password Recovery Wizard";
            Load += PasswordRecoveryWizard_LoadAsync;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questionOne;
        private TextBox answerOnetextBox;
        private TextBox answerTwotextBox;
        private Label QuestionTwo;
        private TextBox answerThreeTextbox;
        private Label QuestionThree;
        private Button verifyButton;
    }
}