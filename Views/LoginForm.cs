using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xrocter.Views
{
    public partial class LoginForm : Form
    {
        private System.Windows.Forms.Timer clipboardTimer;

        public LoginForm()
        {
            InitializeComponent();

        }

        private void CopyUsernameButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(usernameTextBox.Text);
            clipboardTimer.Start();
        }
        private void CopyPasswordButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordTextBox.Text);
            clipboardTimer.Start();
        }
        private void ClipboardTimer_Tick(object sender, EventArgs e)
        {
            Clipboard.Clear();
            clipboardTimer.Stop();
        }
        // Include methods to load data into text boxer
    }
}
