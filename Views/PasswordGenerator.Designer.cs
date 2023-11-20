namespace Xrocter.Views
{
    partial class PasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGenerator));
            label1 = new Label();
            selectionList = new ListBox();
            generateButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Type of Password:";
            // 
            // selectionList
            // 
            selectionList.FormattingEnabled = true;
            selectionList.ItemHeight = 15;
            selectionList.Items.AddRange(new object[] { "Personal", "Enterprise" });
            selectionList.Location = new Point(12, 36);
            selectionList.Name = "selectionList";
            selectionList.Size = new Size(259, 34);
            selectionList.TabIndex = 1;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(106, 82);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(75, 32);
            generateButton.TabIndex = 2;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // PasswordGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 126);
            Controls.Add(generateButton);
            Controls.Add(selectionList);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PasswordGenerator";
            Text = "Password Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox selectionList;
        private Button generateButton;
    }
}