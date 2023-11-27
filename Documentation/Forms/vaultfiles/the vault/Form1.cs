using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_vault
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             // main page
             // Setup DataGridView columns
            dataGridView1.Columns.Add("siteColumn", "Site/Card/SSN");
            dataGridView1.Columns.Add("passwordColumn", "Password");

            // Adjust the column widths as necessary, or set them to fill
            dataGridView1.Columns["siteColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["passwordColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // You can also set other properties for the DataGridView here

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add Button logic
            string site = textBox2.Text; // Replace textBox2 with your actual text box for Site/Card/SSN
            string password = textBox3.Text; // Replace textBox3 with your actual text box for Password

            // Simple validation to ensure that the text boxes are not empty
            if (!string.IsNullOrWhiteSpace(site) && !string.IsNullOrWhiteSpace(password))
            {
                // Add the new row to DataGridView
                dataGridView1.Rows.Add(site, password);

                // Clear the TextBoxes after adding
                textBox2.Clear();
                textBox3.Clear(); // Replace textBox3 with your actual text box for Password
            }
            else
            {
                MessageBox.Show("Please fill in both fields.", "Input Error");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Update Button logic
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Assuming the first selected row is the one to update
                var selectedRow = dataGridView1.SelectedRows[0];

                // Replace the values from TextBoxes
                selectedRow.Cells["siteColumn"].Value = textBox2.Text;
                selectedRow.Cells["passwordColumn"].Value = textBox3.Text;

                // Clear the TextBoxes after updating
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Selection Error");
            }

        }

        private void DeleteButtton_Click(object sender, EventArgs e)
        {
            // Delete button logic
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index); // Removes the selected row
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Selection Error");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            // site / Card / SSN


        }

        private void label2_Click(object sender, EventArgs e)
        {
            //this is for the password text box 



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // this is for the Site/Card/SSN text box 
        }
    }
}
