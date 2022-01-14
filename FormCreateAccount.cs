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

namespace TEAM07
{
    public partial class FormCreateAccount : Form
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataReader dataReader;

        string connectionstring = "Data Source=essql1.walton.uark.edu;Initial Catalog=ISYS4283F21TEAM07;User ID=ISYS4283F21TEAM07;password=GohogsUA1";
        public FormCreateAccount()
        {
            InitializeComponent();
        }

        private void btncreateaccountform_Click(object sender, EventArgs e)
        { //creates new customer in Customers table
            try
            {
                con = new SqlConnection(connectionstring);
                con.Open();
                string sql = "INSERT INTO Customers VALUES (@First_Name, @Last_Name, @Address, @Phone_Number, @Status, @Membership_Type,@Join_Date, @Other_Users, @Password)";
                int answer;
                command = new SqlCommand(sql, con);

                command.Parameters.AddWithValue("@First_Name", txtfirstnamec.Text);
                command.Parameters.AddWithValue("@Last_Name", txtlastnamec.Text);
                command.Parameters.AddWithValue("@Address", txtaddressc.Text);
                command.Parameters.AddWithValue("@Phone_Number", txtphonenumc.Text);
                command.Parameters.AddWithValue("@Status", lblstatusc.Text);
                command.Parameters.AddWithValue("@Membership_Type", cbomembershiptype.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Join_Date", txtjoindatec.Text);
                command.Parameters.AddWithValue("@Other_Users", txtotherusersc.Text);
                command.Parameters.AddWithValue("@Password", txtpasswordc.Text);

                answer = command.ExecuteNonQuery();

                con.Close();
                command.Dispose();
                MessageBox.Show("Account Created! Click the Get ID Button to get your Customer ID");
                
                
               
            }
            catch (Exception ex) { MessageBox.Show("Error " + ex); }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnshowid_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionstring);
            con.Open();
            string sql = "SELECT Customer_ID FROM Customers WHERE First_Name ='" + txtfirstnamec.Text + "' and Last_Name ='" + txtlastnamec.Text + "' and Password = '" + txtpasswordc.Text + "'";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            while (dataReader.Read()) 
            {
                txtnewid.Text = dataReader[0].ToString();
            }



            con.Close();
        }
    }
}
