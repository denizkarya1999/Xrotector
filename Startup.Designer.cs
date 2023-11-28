namespace Xrocter
{
    partial class Startup
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
        private async Task InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameLabel = new Label();
            lastNameTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            createAccountButton = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            PasswordRecoveryLink = new LinkLabel();
            login_Button = new Button();
            Password_Login_Textbox = new TextBox();
            Email_Login_Textbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripSplitButton();
            exitToolStripMenuItem = new ToolStripMenuItem();
            help = new ToolStripDropDownButton();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.Location = new Point(20, 30);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(100, 23);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            firstNameTextBox.Location = new Point(20, 56);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(225, 23);
            firstNameTextBox.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            lastNameLabel.Location = new Point(20, 97);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(100, 23);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            lastNameTextBox.Location = new Point(20, 120);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(225, 23);
            lastNameTextBox.TabIndex = 4;
            // 
            // emailLabel
            // 
            emailLabel.Location = new Point(20, 155);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(100, 23);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Location = new Point(20, 181);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(225, 23);
            emailTextBox.TabIndex = 6;
            // 
            // passwordLabel
            // 
            passwordLabel.Location = new Point(20, 224);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(100, 23);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Location = new Point(20, 250);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(225, 23);
            passwordTextBox.TabIndex = 8;
            // 
            // createAccountButton
            // 
            createAccountButton.BackColor = Color.Green;
            createAccountButton.ForeColor = SystemColors.ControlLightLight;
            createAccountButton.Location = new Point(70, 291);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(115, 48);
            createAccountButton.TabIndex = 9;
            createAccountButton.Text = "Create Account";
            createAccountButton.UseVisualStyleBackColor = false;
            createAccountButton.Click += createAccountButton_ClickAsync;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(passwordLabel);
            groupBox1.Controls.Add(createAccountButton);
            groupBox1.Controls.Add(firstNameLabel);
            groupBox1.Controls.Add(passwordTextBox);
            groupBox1.Controls.Add(firstNameTextBox);
            groupBox1.Controls.Add(emailTextBox);
            groupBox1.Controls.Add(lastNameLabel);
            groupBox1.Controls.Add(emailLabel);
            groupBox1.Controls.Add(lastNameTextBox);
            groupBox1.Location = new Point(314, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 361);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Account";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(PasswordRecoveryLink);
            groupBox2.Controls.Add(login_Button);
            groupBox2.Controls.Add(Password_Login_Textbox);
            groupBox2.Controls.Add(Email_Login_Textbox);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(15, 188);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(278, 206);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sign In";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Location = new Point(149, 168);
            button1.Name = "button1";
            button1.Size = new Size(82, 25);
            button1.TabIndex = 14;
            button1.Text = "Clipboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PasswordRecoveryLink
            // 
            PasswordRecoveryLink.AutoSize = true;
            PasswordRecoveryLink.Location = new Point(68, 143);
            PasswordRecoveryLink.Name = "PasswordRecoveryLink";
            PasswordRecoveryLink.Size = new Size(127, 15);
            PasswordRecoveryLink.TabIndex = 13;
            PasswordRecoveryLink.TabStop = true;
            PasswordRecoveryLink.Text = "Forgot your password?";
            PasswordRecoveryLink.LinkClicked += PasswordRecoveryLink_LinkClickedAsync;
            // 
            // login_Button
            // 
            login_Button.BackColor = SystemColors.ButtonFace;
            login_Button.ForeColor = SystemColors.ActiveCaptionText;
            login_Button.Location = new Point(29, 168);
            login_Button.Name = "login_Button";
            login_Button.Size = new Size(77, 26);
            login_Button.TabIndex = 10;
            login_Button.Text = "Sign In";
            login_Button.UseVisualStyleBackColor = false;
            login_Button.Click += login_Button_Click;
            // 
            // Password_Login_Textbox
            // 
            Password_Login_Textbox.BorderStyle = BorderStyle.FixedSingle;
            Password_Login_Textbox.Location = new Point(16, 107);
            Password_Login_Textbox.Name = "Password_Login_Textbox";
            Password_Login_Textbox.PasswordChar = '*';
            Password_Login_Textbox.Size = new Size(242, 23);
            Password_Login_Textbox.TabIndex = 12;
            // 
            // Email_Login_Textbox
            // 
            Email_Login_Textbox.BorderStyle = BorderStyle.FixedSingle;
            Email_Login_Textbox.Location = new Point(16, 48);
            Email_Login_Textbox.Name = "Email_Login_Textbox";
            Email_Login_Textbox.Size = new Size(242, 23);
            Email_Login_Textbox.TabIndex = 10;
            // 
            // label2
            // 
            label2.Location = new Point(16, 81);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 11;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.Location = new Point(16, 28);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 10;
            label1.Text = "Email:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PC;
            pictureBox1.Location = new Point(15, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ControlLight;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, help });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.ShowItemToolTips = false;
            toolStrip1.Size = new Size(599, 25);
            toolStrip1.TabIndex = 13;
            toolStrip1.Text = "toolBar";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(41, 22);
            toolStripDropDownButton1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // help
            // 
            help.DisplayStyle = ToolStripItemDisplayStyle.Text;
            help.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            help.Image = (Image)resources.GetObject("help.Image");
            help.ImageTransparentColor = Color.Magenta;
            help.Name = "help";
            help.Size = new Size(45, 22);
            help.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // Startup
            // 
            BackColor = SystemColors.Control;
            ClientSize = new Size(599, 413);
            Controls.Add(toolStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Startup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xrocter 1.0 Beta";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private Button createAccountButton;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label emailLabel;
        private Label passwordLabel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private Button login_Button;
        private TextBox Password_Login_Textbox;
        private TextBox Email_Login_Textbox;
        private PictureBox pictureBox1;
        private ToolStrip toolStrip1;
        private ToolStripSplitButton toolStripDropDownButton1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private LinkLabel PasswordRecoveryLink;
        private ToolStripDropDownButton help;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button button1;
    }
}