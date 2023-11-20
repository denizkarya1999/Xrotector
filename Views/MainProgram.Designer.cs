﻿namespace Xrocter.Views
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
            label1 = new Label();
            generatePasswordbutton = new Button();
            WelcomeLabel = new Label();
            navigationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // navigationPanel
            // 
            navigationPanel.BackColor = Color.DarkRed;
            navigationPanel.Controls.Add(label1);
            navigationPanel.Controls.Add(generatePasswordbutton);
            navigationPanel.Location = new Point(-5, -6);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(178, 461);
            navigationPanel.TabIndex = 0;
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
            generatePasswordbutton.Location = new Point(17, 42);
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
            // MainProgram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(WelcomeLabel);
            Controls.Add(navigationPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainProgram";
            Text = "Xrocter - Home";
            Load += MainProgram_Load;
            navigationPanel.ResumeLayout(false);
            navigationPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel navigationPanel;
        private Label label1;
        private Button generatePasswordbutton;
        private Label WelcomeLabel;
    }
}