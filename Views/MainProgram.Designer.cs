namespace Xrocter.Views
{
    partial class MainProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgram));
            navigationPanel = new Panel();
            aboutLink = new LinkLabel();
            maskButton = new Button();
            label1 = new Label();
            generatePasswordbutton = new Button();
            WelcomeLabel = new Label();
            pictureBox1 = new PictureBox();
            navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // navigationPanel
            // 
            navigationPanel.BackColor = Color.DarkRed;
            navigationPanel.Controls.Add(aboutLink);
            navigationPanel.Controls.Add(maskButton);
            navigationPanel.Controls.Add(label1);
            navigationPanel.Controls.Add(generatePasswordbutton);
            navigationPanel.Location = new Point(-5, -6);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(178, 461);
            navigationPanel.TabIndex = 0;
            // 
            // aboutLink
            // 
            aboutLink.AutoSize = true;
            aboutLink.LinkColor = Color.White;
            aboutLink.Location = new Point(44, 432);
            aboutLink.Name = "aboutLink";
            aboutLink.Size = new Size(81, 15);
            aboutLink.TabIndex = 3;
            aboutLink.TabStop = true;
            aboutLink.Text = "About Xrocter";
            aboutLink.LinkClicked += aboutLink_LinkClicked;
            // 
            // maskButton
            // 
            maskButton.BackColor = Color.Red;
            maskButton.BackgroundImageLayout = ImageLayout.None;
            maskButton.ForeColor = SystemColors.ControlLightLight;
            maskButton.Location = new Point(17, 91);
            maskButton.Name = "maskButton";
            maskButton.Size = new Size(147, 34);
            maskButton.TabIndex = 2;
            maskButton.Text = "Mask Vault";
            maskButton.UseVisualStyleBackColor = false;
            maskButton.Click += maskButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(58, 15);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 1;
            label1.Text = "Actions";
            // 
            // generatePasswordbutton
            // 
            generatePasswordbutton.BackColor = Color.Red;
            generatePasswordbutton.BackgroundImageLayout = ImageLayout.None;
            generatePasswordbutton.ForeColor = SystemColors.ControlLightLight;
            generatePasswordbutton.Location = new Point(17, 47);
            generatePasswordbutton.Name = "generatePasswordbutton";
            generatePasswordbutton.Size = new Size(147, 34);
            generatePasswordbutton.TabIndex = 0;
            generatePasswordbutton.Text = "Generate Password";
            generatePasswordbutton.UseVisualStyleBackColor = false;
            generatePasswordbutton.Click += generatePasswordbutton_Click;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            WelcomeLabel.Location = new Point(338, 25);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(288, 50);
            WelcomeLabel.TabIndex = 1;
            WelcomeLabel.Text = "Welcome NULL";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.png_transparent_under_construction_construction_sign_work_warning_symbol_yellow_repair_danger_under_thumbnail1;
            pictureBox1.Location = new Point(258, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(458, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MainProgram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(WelcomeLabel);
            Controls.Add(navigationPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainProgram";
            Text = "Xrocter 1.0 Beta - Home";
            Load += MainProgram_Load;
            navigationPanel.ResumeLayout(false);
            navigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel navigationPanel;
        private Label label1;
        private Button generatePasswordbutton;
        private Label WelcomeLabel;
        private Button maskButton;
        private LinkLabel aboutLink;
        private PictureBox pictureBox1;
    }
}