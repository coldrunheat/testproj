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

            dataGridView1.CellClick += dataGridView1_CellContentClick_1;

            string generatedID = GenerateEmployeeID();
            idtb.Text = generatedID;

        }

        

        private string GenerateEmployeeID()
        {
            string year = DateTime.Now.Year.ToString();
            string idNumber = "";

            // Connect to your database and query for the highest ID number for the current year
            // Assume conn is your SqlConnection object
            try
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kmo\Documents\lgndb.mdf;Integrated Security=True;Connect Timeout=30;"))
                {
                    connect.Open();
                    string query = $"SELECT MAX(emp_id) FROM empdata WHERE emp_id LIKE '{year}%'";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        int maxID = Convert.ToInt32(result.ToString().Substring(4)); // Extract the numeric part
                        idNumber = $"{year}{(maxID + 1).ToString("0000")}";
                    }
                    else
                    {
                        idNumber = $"{year}0001"; // If no records exist for the current year
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Employee ID: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           /* finally
            {
                connect.Close();
            } */
            return idNumber;
        }


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
                using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kmo\Documents\lgndb.mdf;Integrated Security=True;Connect Timeout=30;"))
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
                       // connect.Close();
                        populate();
                    }
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             /*   finally
                {
                    connect.Close();
                }
             */
            }




            private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kmo\Documents\lgndb.mdf;Integrated Security=True;Connect Timeout=30;"))
                {
                    connect.Open();
                    string query = "DELETE FROM empdata where emp_id = '" + idtb.Text + "'; ";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@EmpId", idtb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connect.Close();
                    populate();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        
        private void populate() 
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kmo\Documents\lgndb.mdf;Integrated Security=True;Connect Timeout=30;"))
                {
                    connect.Open();
                    string query = "SELECT * FROM empdata";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    var dset = new DataSet();
                    adapter.Fill(dset);
                    dataGridView1.DataSource = dset.Tables[0];
                   // connect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error loading data " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void importbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg; *.png";
               
                //string imagePath = dialog.FileName;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = dialog.FileName;
                   // imagePath = dialog.FileName;
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

            if (e.RowIndex >= 0)
            {
                // Get the DataGridViewRow corresponding to the clicked cell
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Extract values from the selected row and display them in textboxes
                fnametb.Text = selectedRow.Cells["empfirstname"].Value.ToString();
                mnametb.Text = selectedRow.Cells["empmiddlename"].Value.ToString();
                lnametb.Text = selectedRow.Cells["emplastname"].Value.ToString();
                cnumtb.Text = selectedRow.Cells["empcnum"].Value.ToString();
                addresstb.Text = selectedRow.Cells["empaddress"].Value.ToString();
                projcb.Text = selectedRow.Cells["empproject"].Value.ToString();
                emppos.Text = selectedRow.Cells["emppostn"].Value.ToString();
                empcontactname.Text = selectedRow.Cells["contactname"].Value.ToString();
                empcontactnum.Text = selectedRow.Cells["contactnum"].Value.ToString();
                empcontactaddress.Text = selectedRow.Cells["contactadd"].Value.ToString();
                bdaydp.Value = Convert.ToDateTime(selectedRow.Cells["empbirthdate"].Value);
                startdatedp.Value = Convert.ToDateTime(selectedRow.Cells["empstartdate"].Value);
                enddatedp.Value = Convert.ToDateTime(selectedRow.Cells["empenddate"].Value);
                profpic.ImageLocation = selectedRow.Cells["image"].Value.ToString();
            }
        }

        /*
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Retrieve the birthdate value
                object birthdateObj = selectedRow.Cells["empbirthdate"].Value;
                if (birthdateObj != null && !string.IsNullOrEmpty(birthdateObj.ToString()))
                {
                    DateTime birthdate;

                    if (DateTime.TryParse(birthdateObj.ToString(), out birthdate))
                    {
                        // Set the birthdate value to the DateTimePicker
                        bdaydp.Value = birthdate;
                    }
                    else
                    {
                        MessageBox.Show("Invalid birthdate format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Birthdate column is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                object startdateObj = selectedRow.Cells["empstartdate"].Value;
                if (startdateObj != null && !string.IsNullOrEmpty(startdateObj.ToString()))
                {
                    DateTime startdate;

                    if (DateTime.TryParse(startdateObj.ToString(), out startdate))
                    {
                    
                        startdatedp.Value = startdate;
                    }
                    else
                    {
                        MessageBox.Show("Invalid start date format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Start date column is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                object enddateObj = selectedRow.Cells["empenddate"].Value;
                if (enddateObj != null && !string.IsNullOrEmpty(enddateObj.ToString()))
                {
                    DateTime enddate;

                    if (DateTime.TryParse(enddateObj.ToString(), out enddate))
                    {

                        enddatedp.Value = enddate;
                    }
                    else
                    {
                        MessageBox.Show("Invalid end date format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("End date column is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                // Retrieve the image path value
                object imagePathObj = selectedRow.Cells["image"].Value;
                if (imagePathObj != null && !string.IsNullOrEmpty(imagePathObj.ToString()))
                {
                    string imagePath = imagePathObj.ToString();

                    // Display the image in the PictureBox
                    try
                    {
                        profpic.ImageLocation = imagePath;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Image path column is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        */

        private void updaterecordbtn_Click(object sender, EventArgs e)
        {

            if (fnametb.Text == "")
            {
                MessageBox.Show("Missing Information", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                   // SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kmo\Documents\lgndb.mdf;Integrated Security=True;Connect Timeout=30;");

                    using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kmo\Documents\lgndb.mdf;Integrated Security=True;Connect Timeout=30;"))
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

                        string project = projcb.SelectedItem != null ? projcb.SelectedItem.ToString() : "";
                        string position = emppos.SelectedItem != null ? emppos.SelectedItem.ToString() : "";

                        string query = "UPDATE empdata " + "SET empfirstname = @FirstName, " +
                       "empmiddlename = @MiddleName, " +
                       "emplastname = @LastName, " +
                       "empcnum = @ContactNumber, " +
                       "empaddress = @Address, " +
                       "empbirthdate = @Birthday, " +
                       "empproject = @Project, " +
                       "emppostn = @Position, " +
                       "empstartdate = @StartDate, " +
                       "empenddate = @EndDate, " +
                       "image = @ImagePath, " +
                       "contactname = @EmpContactName, " +
                       "contactnum = @EmpContactNumber, " +
                       "contactadd = @EmpContactAddress " +
                       "WHERE emp_id = '" + idtb.Text + "'; ";



                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {
                            // cmd.Parameters.AddWithValue("@Id", idtb.Text.Trim());
                            cmd.Parameters.AddWithValue("@FirstName", fnametb.Text.Trim());
                            cmd.Parameters.AddWithValue("@MiddleName", mnametb.Text.Trim());
                            cmd.Parameters.AddWithValue("@LastName", lnametb.Text.Trim());
                            cmd.Parameters.AddWithValue("@ContactNumber", cnumtb.Text.Trim());
                            cmd.Parameters.AddWithValue("@Address", addresstb.Text.Trim());
                            cmd.Parameters.AddWithValue("@Birthday", bday);
                            cmd.Parameters.AddWithValue("@Project", project);
                            cmd.Parameters.AddWithValue("@Position", position);
                            cmd.Parameters.AddWithValue("@StartDate", startDate);
                            cmd.Parameters.AddWithValue("@EndDate", endDate);
                            cmd.Parameters.AddWithValue("@ImagePath", path);
                            cmd.Parameters.AddWithValue("@EmpContactName", empcontactname.Text.Trim());
                            cmd.Parameters.AddWithValue("@EmpContactNumber", empcontactnum.Text.Trim());
                            cmd.Parameters.AddWithValue("@EmpContactAddress", empcontactaddress.Text.Trim());

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // dataGridView1.DataSource = null;

                            populate();
                           // dataGridView1.Refresh();
                           // connect.Close();
                        }

                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             }
            
        }
    }
}
