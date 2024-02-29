using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ERS
{
    public partial class RegForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tcbip\OneDrive\Documents\emprsdb.mdf;Integrated Security=True;Connect Timeout=30");
        public RegForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void exitlbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_loginbtn_Click(object sender, EventArgs e)
        {
            if(signup_uname.Text == "" || signup_pass.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        //Check if user exists
                        string selectUname = "SELECT COUNT(id) FROM userdb WHERE username = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectUname, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", signup_uname.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if(count >= 1) 
                            {
                                MessageBox.Show(signup_uname.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO userdb " + "(username, password, date_register) " + "VALUES(@username, @password, @dateReg)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_uname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_pass.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();


                                    MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Login loginForm = new Login();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }



                        }

     

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           signup_pass.PasswordChar = signup_showpass.Checked ? '\0' : '*';
        }

        private void signup_loginbtn_Click_1(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
