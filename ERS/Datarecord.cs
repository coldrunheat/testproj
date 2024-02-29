using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ERS
{
    class EmployeeData
    {
        public int ID { set; get; }
        public string EmployeeID { set; get; }
        public string FirstName { set; get; }
        public string MiddleName { set; get; }
        public string LastName { set; get; }
      /*  public string EmployeeContactNumber { set; get; }
        public string Birthdate { set; get; }
        public string EmployeeAddress { set; get; }
        public string Project { set; get; }
        public string Startdate { set; get; }
        public string Enddate { set; get; }
        public string Image { set; get; }
        public string EmergencyContactName { set; get; }
        public string EmergencyContactNumber { set; get; }
        public string EmergencyContactAddress { set; get; }
      */
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kmo\Documents\lgndb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
    
       public List<EmployeeData> employeeListData()
        {
            List<EmployeeData> listdata = new List<EmployeeData>();

            if(connect.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM empdata WHERE delete_date IS NULL";

                    using(SqlCommand cmd = new SqlCommand(selectData, connect)) 
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            EmployeeData ed = new EmployeeData();
                            ed.ID = (int)reader["id"];
                            ed.EmployeeID = reader["emp_id"].ToString();
                            ed.FirstName = reader["firstname"].ToString();
                            ed.MiddleName = reader["middlename"].ToString();
                            ed.LastName = reader["lastname"].ToString();
                         /*   dr.EmployeeContactNumber = reader["contactnumtb"].ToString();
                            dr.Birthdate = reader["bdaydp"].ToString();
                            dr.EmployeeAddress = reader["addresstb"].ToString();
                            dr.Project = reader["projcb"].ToString();
                            dr.Startdate = reader["startdatedp"].ToString();
                            dr.Enddate = reader["enddatedp"].ToString();
                            dr.Image = reader["profpic"].ToString();
                            dr.EmergencyContactName = reader["empcontactname"].ToString();
                            dr.EmergencyContactNumber = reader["empcontactnum"].ToString();
                            dr.EmergencyContactAddress = reader["empcontactaddress"].ToString();
                          */
                            listdata.Add(ed);

                        }
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;

        }
    
    }
}
