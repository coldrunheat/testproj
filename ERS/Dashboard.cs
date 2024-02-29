using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(check == DialogResult.Yes) 
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
        }

        private void addrecordbtn_Click(object sender, EventArgs e)
        {
            addRecord1.Visible = true;
            generateCOEID1.Visible = false;
        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            addRecord1.Visible = false;
            generateCOEID1.Visible = true;
        }

        private void generatebtn_Click_1(object sender, EventArgs e)
        {
            addRecord1.Visible = true;
            generateCOEID1.Visible = false;
        }
    }
}
