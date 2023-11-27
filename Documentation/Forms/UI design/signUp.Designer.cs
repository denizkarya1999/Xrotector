namespace MyPass
{
    partial class signUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signUp));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(225, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(343, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AccessibleDescription = "";
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(368, 319);
            label2.Name = "label2";
            label2.Size = new Size(87, 18);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AccessibleDescription = "";
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(368, 257);
            label1.Name = "label1";
            label1.Size = new Size(92, 18);
            label1.TabIndex = 8;
            label1.Text = "UserName";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Location = new Point(287, 340);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 36);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(287, 278);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 36);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AccessibleDescription = "";
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(383, 386);
            label3.Name = "label3";
            label3.Size = new Size(51, 18);
            label3.TabIndex = 11;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InactiveCaption;
            textBox3.Location = new Point(287, 407);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(242, 36);
            textBox3.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Location = new Point(322, 474);
            button1.Name = "button1";
            button1.Size = new Size(178, 46);
            button1.TabIndex = 12;
            button1.Text = "SignUp";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(746, 570);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox3;
        private Button button1;
    }
}