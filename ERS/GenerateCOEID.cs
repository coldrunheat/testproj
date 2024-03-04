using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS
{
    public partial class GenerateCOEID : UserControl
    {
        public GenerateCOEID()
        {
            InitializeComponent();

            // Attach the KeyDown event handler to the text box
            lnamesearch.KeyDown += TextBoxSearch_KeyDown;
        }

        private void fetchdata()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kmo\Documents\lgndb.mdf;Integrated Security=True;Connect Timeout=30;"))
                {
                    connect.Open();

                    string query = "SELECT * FROM empdata WHERE emplastname = @LastName";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@LastName", lnamesearch.Text.Trim());

                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);

                    // Check if any rows were returned
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No record found for the specified last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }

                    foreach (DataRow dr in dt.Rows)
                    {
                        string empId = dr["emp_id"].ToString();

                        string imagePathQuery = "SELECT image_path FROM emp_images WHERE emp_id = @EmpId";
                        SqlCommand imagePathCmd = new SqlCommand(imagePathQuery, connect);
                        imagePathCmd.Parameters.AddWithValue("@EmpId", empId);
                        object result = imagePathCmd.ExecuteScalar();


                        if (result != null) 
                        {
                            string imagePath = result.ToString();

                        if (System.IO.File.Exists(imagePath))
                        {
                            try
                            {
                                // Load the image into the PictureBox
                                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                                {
                                    pbsearch.Image = Image.FromStream(fs);
                                }
                            }
                            catch (Exception ex)
                            {
                                // Handle any exceptions that occur during image loading
                                MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            // Handle case where file does not exist
                            MessageBox.Show("Image file does not exist: " + imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        }
                        else
                        {
                            MessageBox.Show("No image found for employee ID: " + empId, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        idnumsearch.Text = dr["emp_id"].ToString();
                        fnamesearch.Text = dr["empfirstname"].ToString();
                        mnamesearch.Text = dr["empmiddlename"].ToString();
                        lnamesearch1.Text = dr["emplastname"].ToString();
                        addresssearch.Text = dr["empaddress"].ToString();
                        cnumsearch.Text = dr["empcnum"].ToString();

                        DateTime birthdate;
                        if (DateTime.TryParse(dr["empbirthdate"].ToString(), out birthdate))
                        {
                            bdaysearch.Text = birthdate.ToString("MM/dd/yyyy");
                        }
                        else
                        {
                            bdaysearch.Text = "Invalid Date";
                        }

                        projectsearch.Text = dr["empproject"].ToString();
                        positionsearch.Text = dr["emppostn"].ToString();

                        DateTime startDate;
                        if (DateTime.TryParse(dr["empstartdate"].ToString(), out startDate))
                        {
                            startdatesearch.Text = startDate.ToString("MM/dd/yyyy");
                        }
                        else
                        {
                            startdatesearch.Text = "Invalid Date";
                        }

                        DateTime endDate;
                        if (DateTime.TryParse(dr["empenddate"].ToString(), out endDate))
                        {
                            enddatesearch.Text = endDate.ToString("MM/dd/yyyy");
                        }
                        else
                        {
                            enddatesearch.Text = "Invalid Date";
                        }


                        emrcnamesrch.Text = dr["contactname"].ToString();
                        emrcnumsrch.Text = dr["contactnum"].ToString();
                        emrcnumadd.Text = dr["contactadd"].ToString();
                    }

                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                // Handle any other exceptions that occur during database operations
                MessageBox.Show("Error fetching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void importbtn_Click(object sender, EventArgs e)
        {

        }

        private void profpic_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void emcontactnum_Click(object sender, EventArgs e)
        {

        }

        private void emcontactname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void enddate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void projcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void emcontactaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void contactnumtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lnametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mnametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fnametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GenerateCOEID_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying print preview: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            fetchdata();
        }

        private void cnumsearch_TextChanged(object sender, EventArgs e)
        {

        }


        private void ClearControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox && c.Name != "idtb")
                {
                    ((TextBox)c).Clear(); // Clear textboxes
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            ClearControls(this);
        }

        private void lnamesearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is Enter (key code 13)
            if (e.KeyCode == Keys.Enter)
            {
                // Call the method to fetch data when Enter is pressed
                fetchdata();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
              string logoPath = @"C:\Users\kmo\source\repos\ERS\ERS\Assets\PSAHeader.png";

              // Load the logo image from the specified path
              Image logo = Image.FromFile(logoPath);

              // Draw the logo at a specific location on the page
              e.Graphics.DrawImage(logo, new PointF(50, 50));
            
            try
            {
                e.Graphics.DrawString("CERTIFICATE OF SERVICES RENDERED", new Font("Arial", 20), Brushes.Black, new Point(150,200));
                float textWidth = e.Graphics.MeasureString("CERTIFICATE OF SERVICES RENDERED", new Font("Arial", 20)).Width;

                // Draw a line underneath the text
                e.Graphics.DrawLine(Pens.Black, 150, 220 + e.Graphics.MeasureString("CERTIFICATE OF SERVICES RENDERED", new Font("Arial", 20)).Height, 150 + textWidth, 220 + e.Graphics.MeasureString("CERTIFICATE OF SERVICES RENDERED", new Font("Arial", 20)).Height);

                // Extract the first letter from the middle name and add a period
                string middleInitial = mnamesearch.Text.Length > 0 ? mnamesearch.Text[0] + "." : "";

                e.Graphics.DrawString("This is to certify that " + fnamesearch.Text + " " + middleInitial + " " + lnamesearch1.Text + ", has been hired as a Contract of", new Font("Arial", 16), Brushes.Black, new Point(60, 270));
                e.Graphics.DrawString("Service Worker at the Philippine Statistics Authority - Davao", new Font("Arial", 16), Brushes.Black, new Point(60, 300));
                e.Graphics.DrawString("Occidental Provincial Statistical Office for the following activities: ", new Font("Arial", 16), Brushes.Black, new Point(60, 330));
                //  e.Graphics.DrawString("following activities: ", new Font("Arial", 20), Brushes.Black, new Point(100, 360));

                // Define table dimensions
                int numRows = 3;
                int numCols = 3;
                float cellWidth = 150;
                float cellHeight = 30;

                // Define starting position of the table
                float startX = 200;
                float startY = 380;

                // Draw table outline
                for (int row = 0; row <= numRows; row++)
                {
                    e.Graphics.DrawLine(Pens.Black, startX, startY + row * cellHeight, startX + numCols * cellWidth, startY + row * cellHeight);
                }

                for (int col = 0; col <= numCols; col++)
                {
                    e.Graphics.DrawLine(Pens.Black, startX + col * cellWidth, startY, startX + col * cellWidth, startY + numRows * cellHeight);
                }

                // Draw cell contents
                string[,] contents = {
        { "ACTIVITY", "POSITION", "PERIOD COVERED"  },
        { " + projectsearch.Text + ", "Row 2, Col 2", "Row 2, Col 3" },
        { "Row 3, Col 1", "Row 3, Col 2", "Row 3, Col 3" }
    };

                for (int row = 0; row < numRows; row++)
                {
                    for (int col = 0; col < numCols; col++)
                    {
                        string text = contents[row, col];
                        float x = startX + col * cellWidth + 5; // Add padding
                        float y = startY + row * cellHeight + 5; // Add padding
                        e.Graphics.DrawString(text, new Font("Arial", 12), Brushes.Black, x, y);
                    }
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error drawing print page: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
