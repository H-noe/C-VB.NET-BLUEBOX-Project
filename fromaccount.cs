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
    public partial class formaccount : Form
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataReader datareader;
        string connectionstring = "Data Source=essql1.walton.uark.edu;Initial Catalog=ISYS4283F21TEAM07;User ID=ISYS4283F21TEAM07;password=GohogsUA1";
        public formaccount()
        {

            InitializeComponent();
        }

        private void formaccount_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter Customer ID# and Last Name to verify information");
            this.Hide();

           

        }

        private void btnviewaccountinfo_Click(object sender, EventArgs e)
        {   //Populates user information textboxes with information
            try
            {
                con = new SqlConnection(connectionstring);
                con.Open();
                string sql = "SELECT Customer_ID,First_Name,Last_Name,Address,Phone_Number,Status,Membership_Type,Join_Date,Other_Users, Password FROM Customers WHERE Last_Name = '" + txtlastnamea.Text + "'and Customer_ID='" + txtcustomerida.Text + "'";
                command = new SqlCommand(sql, con);
                datareader = command.ExecuteReader();
                while (datareader.Read())
                {
                    txtcustomerida.Text = datareader[0].ToString();
                    txtfirstnamea.Text = datareader[1].ToString();
                    txtlastnamea.Text = datareader[2].ToString();
                    txtaddressa.Text = datareader[3].ToString();
                    txtphonenuma.Text = datareader[4].ToString();
                    txtstatusa.Text = datareader[5].ToString();
                    txtmembershiptypea.Text = datareader[6].ToString();
                    txtjoindatea.Text = datareader[7].ToString();
                    txtotherusersa.Text = datareader[8].ToString();
                    txtpassworda.Text = datareader[9].ToString();
                }
                con.Close();
                command.Dispose();
                datareader.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error - Make sure your Last Name and Customer ID# are correct!" + ex); }
        }

        private void btncustomerupdate_Click(object sender, EventArgs e)
        {   //Updates customer record in the Customers table with new values
            try
            {
                txtstatusa.Text = "";
                txtmembershiptypea.Text = "";
                txtjoindatea.Text = "";
                con = new SqlConnection(connectionstring);
                con.Open();
                string sql = "UPDATE Customers SET First_Name=@First_Name, Last_Name=@Last_Name, Address=@Address, Phone_Number=@Phone_Number, Other_Users=@Other_Users, Password=@Password WHERE Customer_ID = '" +txtcustomerida.Text + "'";
                int answer;
                command = new SqlCommand(sql, con);

                command.Parameters.AddWithValue("@First_Name", txtfirstnamea.Text);
                command.Parameters.AddWithValue("@Last_Name", txtlastnamea.Text);
                command.Parameters.AddWithValue("@Address", txtaddressa.Text);
                command.Parameters.AddWithValue("@Phone_Number", txtphonenuma.Text);  
                command.Parameters.AddWithValue("@Other_Users", txtotherusersa.Text);
                command.Parameters.AddWithValue("@Password", txtpassworda.Text);

                answer = command.ExecuteNonQuery();

                con.Close();
                command.Dispose();
                MessageBox.Show("Account Information Has Been Updated");
               


            }
            catch (Exception ex) { MessageBox.Show("You cannot change you membership type, join date, or status in this menu!" + ex); }
        }
    }
}
