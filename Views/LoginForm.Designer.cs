namespace Xrocter.Views
{
    partial class LoginForm
    {
        private TextBox usernameTextBox;
        private Button copyUsernameButton;
        private TextBox passwordTextBox;
        private Button copyPasswordButton;
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            usernameTextBox = new TextBox();
            copyUsernameButton = new Button();
            passwordTextBox = new TextBox();
            copyPasswordButton = new Button();
            clipboardTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(87, 15);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(225, 23);
            usernameTextBox.TabIndex = 0;
            // 
            // copyUsernameButton
            // 
            copyUsernameButton.Location = new Point(332, 15);
            copyUsernameButton.Name = "copyUsernameButton";
            copyUsernameButton.Size = new Size(75, 23);
            copyUsernameButton.TabIndex = 1;
            copyUsernameButton.Text = "Copy Username";
            copyUsernameButton.Click += CopyUsernameButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(87, 55);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(225, 23);
            passwordTextBox.TabIndex = 2;
            // 
            // copyPasswordButton
            // 
            copyPasswordButton.Location = new Point(332, 54);
            copyPasswordButton.Name = "copyPasswordButton";
            copyPasswordButton.Size = new Size(75, 23);
            copyPasswordButton.TabIndex = 3;
            copyPasswordButton.Text = "Copy Password";
            copyPasswordButton.Click += CopyPasswordButton_Click;
            // 
            // clipboardTimer
            // 
            clipboardTimer.Interval = 30000;
            clipboardTimer.Tick += ClipboardTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Email:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 96);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usernameTextBox);
            Controls.Add(copyUsernameButton);
            Controls.Add(passwordTextBox);
            Controls.Add(copyPasswordButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Text = "Sensitive Data Clipboard - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
    }
}