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
using System.Threading;
using System.Runtime.Remoting.Contexts;

namespace ERS
{
    public partial class AddRecord : UserControl
    {
        private bool isNewRecord = true;

        public AddRecord()
        {
            InitializeComponent();

            dataGridView1.CellClick += dataGridView1_CellContentClick_1;

            if (isNewRecord)
            {
                string generatedID = GenerateEmployeeID();
                idtb.Text = generatedID;
            }
        }


        private string GenerateEmployeeID()
        {
            string year = DateTime.Now.Year.ToString();
            string idNumber = "";

            try
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kmo\Documents\lgndb.mdf;Integrated Security=True;Connect Timeout=30;"))
                {
                    connect.Open();
                    string query = $"SELECT emp_id FROM empdata WHERE emp_id LIKE '{year}-%' ORDER BY emp_id";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataReader reader = cmd.ExecuteReader();

                    int expectedIDNumber = 1;
                    while (reader.Read())
                    {
                        string currentID = reader["emp_id"].ToString();
                        int currentIndex = int.Parse(currentID.Split('-')[1]);

                        // If the current index does not match the expected index, a gap is found
                        if (currentIndex != expectedIDNumber)
                        {
                            idNumber = $"{year}-{expectedIDNumber.ToString("0000")}";
                            break;
                        }

                        // If no gaps are found, increment the expected index
                        expectedIDNumber++;
                    }

                    // If all existing IDs are sequential, generate the next ID in sequence
                    if (string.IsNullOrEmpty(idNumber))
                    {
                        idNumber = $"{year}-{expectedIDNumber.ToString("0000")}";
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Employee ID: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                if (string.IsNullOrEmpty(idtb.Text) || string.IsNullOrEmpty(fnametb.Text))
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(profpic.ImageLocation))
                {
                    MessageBox.Show("Please select an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!File.Exists(profpic.ImageLocation))
                {
                    MessageBox.Show("Image file does not exist at the specified location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kmo\Documents\lgndb.mdf;Integrated Security=True;Connect Timeout=30;"))
                {
                    connect.Open();

                    string directoryPath = Path.Combine(@"C:\Users\kmo\source\repos\ERS\ERS\Directory\", idtb.Text.Trim());
                    string imagePath = Path.Combine(directoryPath, "image.jpg");


                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    File.Copy(profpic.ImageLocation, imagePath, true);

                    string bday = bdaydp.Value.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
                    string startDate = startdatedp.Value.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
                    string endDate = enddatedp.Value.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);

                    string project = projcb.SelectedItem?.ToString() ?? "";
                    string position = emppos.SelectedItem?.ToString() ?? "";



                    string empDataQuery = "INSERT INTO empdata (emp_id, empfirstname, empmiddlename, emplastname, empcnum, empaddress,empbirthdate, empproject, emppostn, empstartdate, empenddate, contactname, contactnum, contactadd) " +
                    "VALUES (@Id, @FirstName, @MiddleName, @LastName, @ContactNumber, @Address, @Birthday, @Project, @Position, @StartDate, @EndDate, @EmpContactName, @EmpContactNumber, @EmpContactAddress)";

                    using (SqlCommand empDatacmd = new SqlCommand(empDataQuery, connect))
                    {
                        empDatacmd.Parameters.AddWithValue("@Id", idtb.Text.Trim());
                        empDatacmd.Parameters.AddWithValue("@FirstName", fnametb.Text.Trim());
                        empDatacmd.Parameters.AddWithValue("@MiddleName", mnametb.Text.Trim());
                        empDatacmd.Parameters.AddWithValue("@LastName", lnametb.Text.Trim());
                        empDatacmd.Parameters.AddWithValue("@ContactNumber", cnumtb.Text.Trim());
                        empDatacmd.Parameters.AddWithValue("@Address", addresstb.Text.Trim());
                        empDatacmd.Parameters.AddWithValue("@Birthday", bday);
                        empDatacmd.Parameters.AddWithValue("@Project", project);
                        empDatacmd.Parameters.AddWithValue("@Position", position);
                        empDatacmd.Parameters.AddWithValue("@StartDate", startDate);
                        empDatacmd.Parameters.AddWithValue("@EndDate", endDate);
                        empDatacmd.Parameters.AddWithValue("@EmpContactName", empcontactname.Text.Trim());
                        empDatacmd.Parameters.AddWithValue("@EmpContactNumber", empcontactnum.Text.Trim());
                        empDatacmd.Parameters.AddWithValue("@EmpContactAddress", empcontactaddress.Text.Trim());

                        empDatacmd.ExecuteNonQuery();
                    }

                    string empImagesQuery = "INSERT INTO emp_images (emp_id, image_path) VALUES (@Id, @ImagePath)";

                    using (SqlCommand empImagesCmd = new SqlCommand(empImagesQuery, connect))
                    {
                        empImagesCmd.Parameters.AddWithValue("@Id", idtb.Text.Trim());
                        empImagesCmd.Parameters.AddWithValue("@ImagePath", imagePath);

                        empImagesCmd.ExecuteNonQuery();
                    }


                    MessageBox.Show("Record Successfully Added", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // connect.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }


            private void button4_Click(object sender, EventArgs e)
        {
            ClearControls(this);

            string generatedID = GenerateEmployeeID();
            idtb.Text = generatedID;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kmo\Documents\lgndb.mdf;Integrated Security=True;Connect Timeout=30;"))
                {
                    connect.Open();

                    string deleteImagesQuery = "DELETE FROM emp_images WHERE emp_id = @EmpId";
                    using (SqlCommand deleteImagesCmd = new SqlCommand(deleteImagesQuery, connect))
                    {
                        deleteImagesCmd.Parameters.AddWithValue("@EmpId", idtb.Text);
                        deleteImagesCmd.ExecuteNonQuery();
                    }


                    string deleteDataQuery = "DELETE FROM empdata where emp_id = '" + idtb.Text + "'; ";

                    using (SqlCommand deleteDataCmd = new SqlCommand(deleteDataQuery, connect))
                    {
                        deleteDataCmd.Parameters.AddWithValue("@EmpId", idtb.Text);
                        deleteDataCmd.ExecuteNonQuery();
                    }

    
                    MessageBox.Show("Record Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error loading data " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox && c.Name != "idtb")
                {
                    ((TextBox)c).Clear(); // Clear textboxes
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1; // Reset combo boxes
                }
                else if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).Value = DateTime.Now; // Reset date pickers to default value
                }
                else if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
                else if (c.HasChildren)
                {
                    ClearControls(c); // Recursively clear controls if they have child controls
                }
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

                    using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        profpic.Image = System.Drawing.Image.FromStream(fs);
                    }


                    // Save the image path for later use if needed
                    profpic.ImageLocation = imagePath;
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Get the DataGridViewRow corresponding to the clicked cell
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                    isNewRecord = false;

                    // Extract values from the selected row and display them in textboxes
                    idtb.Text = selectedRow.Cells["emp_id"].Value.ToString();
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


                    using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kmo\Documents\lgndb.mdf;Integrated Security=True;Connect Timeout=30;"))
                    {
                        connect.Open();
                        string imagePathQuery = $"SELECT image_path FROM emp_images WHERE emp_id = '{idtb.Text}'";
                        SqlCommand cmd = new SqlCommand(imagePathQuery, connect);
                        string imagePath = cmd.ExecuteScalar()?.ToString();

                        if (!string.IsNullOrEmpty(imagePath))
                        {
                            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                            {
                                profpic.Image = System.Drawing.Image.FromStream(fs);
                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log the exception
               // Console.WriteLine($"Error in dataGridView1_CellContentClick_1: {ex}");
            }
        }


        private void updaterecordbtn_Click(object sender, EventArgs e)
        {
            
            if (fnametb.Text == "")
            {
                MessageBox.Show("Missing Information", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            { 
                    using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kmo\Documents\lgndb.mdf;Integrated Security=True;Connect Timeout=30;"))
                    {
                        connect.Open();

                        string directoryPath = Path.Combine(@"C:\Users\kmo\source\repos\ERS\ERS\Directory\", idtb.Text.Trim());
                        string imagePath = Path.Combine(directoryPath, "image.jpg");

                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                    if (!File.Exists(imagePath))
                    {
                        MessageBox.Show("Image file does not exist at the specified location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                        string bday = bdaydp.Value.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
                        string startDate = startdatedp.Value.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
                        string endDate = enddatedp.Value.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);

                        string project = projcb.SelectedItem != null ? projcb.SelectedItem.ToString() : "";
                        string position = emppos.SelectedItem != null ? emppos.SelectedItem.ToString() : "";

                        string updateDataQuery = "UPDATE empdata " + "SET empfirstname = @FirstName, " +
                       "empmiddlename = @MiddleName, " +
                       "emplastname = @LastName, " +
                       "empcnum = @ContactNumber, " +
                       "empaddress = @Address, " +
                       "empbirthdate = @Birthday, " +
                       "empproject = @Project, " +
                       "emppostn = @Position, " +
                       "empstartdate = @StartDate, " +
                       "empenddate = @EndDate, " +
                       "image = @ImagePath," +
                       "contactname = @EmpContactName, " +
                       "contactnum = @EmpContactNumber, " +
                       "contactadd = @EmpContactAddress " +
                       "WHERE emp_id = '" + idtb.Text + "';";



                        using (SqlCommand updateDataCmd = new SqlCommand(updateDataQuery, connect))
                        {
                            // cmd.Parameters.AddWithValue("@Id", idtb.Text.Trim());
                            updateDataCmd.Parameters.AddWithValue("@FirstName", fnametb.Text.Trim());
                            updateDataCmd.Parameters.AddWithValue("@MiddleName", mnametb.Text.Trim());
                            updateDataCmd.Parameters.AddWithValue("@LastName", lnametb.Text.Trim());
                            updateDataCmd.Parameters.AddWithValue("@ContactNumber", cnumtb.Text.Trim());
                            updateDataCmd.Parameters.AddWithValue("@Address", addresstb.Text.Trim());
                            updateDataCmd.Parameters.AddWithValue("@Birthday", bday);
                            updateDataCmd.Parameters.AddWithValue("@Project", project);
                            updateDataCmd.Parameters.AddWithValue("@Position", position);
                            updateDataCmd.Parameters.AddWithValue("@StartDate", startDate);
                            updateDataCmd.Parameters.AddWithValue("@EndDate", endDate);
                            updateDataCmd.Parameters.AddWithValue("@EmpContactName", empcontactname.Text.Trim());
                            updateDataCmd.Parameters.AddWithValue("@EmpContactNumber", empcontactnum.Text.Trim());
                            updateDataCmd.Parameters.AddWithValue("@EmpContactAddress", empcontactaddress.Text.Trim());


                            updateDataCmd.ExecuteNonQuery();

                        }
                        
                        string updateImagesQuery = "UPDATE emp_images SET image_path = @ImagePath WHERE emp_id = @EmpId";
                        using (SqlCommand updateImagesCmd = new SqlCommand(updateImagesQuery, connect))
                        {
                            updateImagesCmd.Parameters.AddWithValue("@EmpId", idtb.Text.Trim());
                            updateImagesCmd.Parameters.AddWithValue("@ImagePath", imagePath);

                            updateImagesCmd.ExecuteNonQuery();
                        }

                    MessageBox.Show("Record Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    populate();
                }
              }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        private void bdaydp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void empcontactnum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
