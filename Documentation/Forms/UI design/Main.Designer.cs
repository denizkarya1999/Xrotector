namespace MyPass
{
    partial class Main
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
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            mainContent = new Panel();
            panel4 = new Panel();
            LogoName = new TextBox();
            MainPageAllButton = new Button();
            MainPageFavorites = new Button();
            MainPageCards = new Button();
            MainPageTrash = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            mainContent.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(MainPageTrash);
            panel1.Controls.Add(MainPageCards);
            panel1.Controls.Add(MainPageFavorites);
            panel1.Controls.Add(MainPageAllButton);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(150, 602);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(150, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(757, 68);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.AccessibleName = "LogoutButton";
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(609, 12);
            button1.Name = "button1";
            button1.Size = new Size(128, 41);
            button1.TabIndex = 0;
            button1.Text = "LogOut";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(261, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 30);
            textBox1.TabIndex = 2;
            textBox1.Text = "My Vault";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // mainContent
            // 
            mainContent.Controls.Add(panel6);
            mainContent.Controls.Add(panel5);
            mainContent.Controls.Add(panel3);
            mainContent.Location = new Point(261, 185);
            mainContent.Name = "mainContent";
            mainContent.Size = new Size(515, 381);
            mainContent.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Controls.Add(LogoName);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(150, 100);
            panel4.TabIndex = 0;
            // 
            // LogoName
            // 
            LogoName.BackColor = Color.FromArgb(224, 224, 224);
            LogoName.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LogoName.Location = new Point(12, 35);
            LogoName.Margin = new Padding(0);
            LogoName.Multiline = true;
            LogoName.Name = "LogoName";
            LogoName.Size = new Size(119, 33);
            LogoName.TabIndex = 3;
            LogoName.Text = "MyPass";
            LogoName.TextAlign = HorizontalAlignment.Center;
            // 
            // MainPageAllButton
            // 
            MainPageAllButton.Dock = DockStyle.Top;
            MainPageAllButton.Location = new Point(0, 100);
            MainPageAllButton.Name = "MainPageAllButton";
            MainPageAllButton.Size = new Size(150, 85);
            MainPageAllButton.TabIndex = 1;
            MainPageAllButton.Text = "ALL";
            MainPageAllButton.UseVisualStyleBackColor = true;
            MainPageAllButton.Click += MainPageAllButton_Click;
            // 
            // MainPageFavorites
            // 
            MainPageFavorites.Dock = DockStyle.Top;
            MainPageFavorites.Location = new Point(0, 185);
            MainPageFavorites.Name = "MainPageFavorites";
            MainPageFavorites.Size = new Size(150, 85);
            MainPageFavorites.TabIndex = 2;
            MainPageFavorites.Text = "Favorites";
            MainPageFavorites.UseVisualStyleBackColor = true;
            MainPageFavorites.Click += button3_Click;
            // 
            // MainPageCards
            // 
            MainPageCards.Dock = DockStyle.Top;
            MainPageCards.Location = new Point(0, 270);
            MainPageCards.Name = "MainPageCards";
            MainPageCards.Size = new Size(150, 85);
            MainPageCards.TabIndex = 3;
            MainPageCards.Text = "Cards";
            MainPageCards.UseVisualStyleBackColor = true;
            MainPageCards.Click += button4_Click;
            // 
            // MainPageTrash
            // 
            MainPageTrash.Dock = DockStyle.Top;
            MainPageTrash.Location = new Point(0, 355);
            MainPageTrash.Name = "MainPageTrash";
            MainPageTrash.Size = new Size(150, 85);
            MainPageTrash.TabIndex = 4;
            MainPageTrash.Text = "Trash";
            MainPageTrash.UseVisualStyleBackColor = true;
            MainPageTrash.Click += button5_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(130, 381);
            panel3.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(130, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(130, 381);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(260, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(130, 381);
            panel6.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(277, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(408, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(535, 156);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(664, 156);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 7;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(907, 602);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(mainContent);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Main";
            Text = "Form3";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            mainContent.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private TextBox textBox1;
        private Panel mainContent;
        private Button MainPageAllButton;
        private Panel panel4;
        private TextBox LogoName;
        private Button MainPageTrash;
        private Button MainPageCards;
        private Button MainPageFavorites;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}