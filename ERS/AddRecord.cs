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
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace ERS
{
    public partial class AddRecord : UserControl
    {

        public AddRecord()
        {
            InitializeComponent();

         
        }

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kmo\Documents\lgndb.mdf;Integrated Security=True;Connect Timeout=30;");


        private void AddRecord_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

                if (string.IsNullOrEmpty(idtb.Text) || string.IsNullOrEmpty(fnametb.Text))
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    connect.Open();

                    string path = Path.Combine(@"C:\Users\kmo\source\repos\ERS\ERS\Directory\", idtb.Text.Trim() + ".jpg");

                    if (!Directory.Exists(Path.GetDirectoryName(path)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(path));
                    }

                    if (!string.IsNullOrEmpty(profpic.ImageLocation))
                    {
                        File.Copy(profpic.ImageLocation, path, true);
                    }
                    else
                    {
                        MessageBox.Show("Image location is null or empty", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string bday = bdaydp.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                    string startDate = startdatedp.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                    string endDate = enddatedp.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

                    

                string query = "INSERT INTO empdata (emp_id, empfirstname, empmiddlename, emplastname, empcnum, empaddress,empbirthdate, empproject, emppostn, empstartdate, empenddate, image, contactname, contactnum, contactadd) " +
                    "VALUES (@Id, @FirstName, @MiddleName, @LastName, @ContactNumber, @Address, @Birthday, @Project, @Position, @StartDate, @EndDate, @ImagePath, @EmpContactName, @EmpContactNumber, @EmpContactAddress)";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@Id", idtb.Text.Trim());
                        cmd.Parameters.AddWithValue("@FirstName", fnametb.Text.Trim());
                        cmd.Parameters.AddWithValue("@MiddleName", mnametb.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", lnametb.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", cnumtb.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", addresstb.Text.Trim());
                        cmd.Parameters.AddWithValue("@Birthday", bday);
                        cmd.Parameters.AddWithValue("@Project", projcb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Position", emppos.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);
                        cmd.Parameters.AddWithValue("@ImagePath", path);
                        cmd.Parameters.AddWithValue("@EmpContactName", empcontactname.Text.Trim());
                        cmd.Parameters.AddWithValue("@EmpContactNumber", empcontactnum.Text.Trim());
                        cmd.Parameters.AddWithValue("@EmpContactAddress", empcontactaddress.Text.Trim());

                        cmd.ExecuteNonQuery();
                        
                        MessageBox.Show("Record Successfully Added", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connect.Close();
                        populate();
                    }
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }




            private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string query = "DELETE FROM empdata where emp_id = '" + idtb.Text + "'; ";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully");
                connect.Close();
                populate();
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        
        private void populate() 
        {
            connect.Open();
            string query = "SELECT * FROM empdata";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var dset = new DataSet();
            adapter.Fill(dset);
            dataGridView1.DataSource = dset.Tables[0];
            connect.Close();

        }


        private void importbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg; *.png";
                string imagePath = dialog.FileName;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    profpic.ImageLocation = imagePath;
                }
            } 
            catch(Exception ex) 
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            /*
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            MessageBox.Show($"Clicked on cell in column {columnIndex} and row {rowIndex}");
            */
            
            idtb.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            fnametb.Text = dataGridView1.SelectedRows[0].Cells["empfirstname"].Value.ToString();
            mnametb.Text = dataGridView1.SelectedRows[0].Cells["empmiddlename"].Value.ToString();
            lnametb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            cnumtb.Text = dataGridView1.SelectedRows[0].Cells["empcnum"].Value.ToString();
            addresstb.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            projcb.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            emppos.Text = dataGridView1.SelectedRows[0].Cells["emppstn"].Value.ToString();
            empcontactname.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            empcontactnum.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            empcontactaddress.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            
        }
    }
}
