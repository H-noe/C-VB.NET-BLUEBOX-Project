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
    public partial class ForogtID : Form
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataReader datareader;
        string connectionstring = "Data Source=essql1.walton.uark.edu;Initial Catalog=ISYS4283F21TEAM07;User ID=ISYS4283F21TEAM07;password=GohogsUA1";
        public ForogtID()
        {
            InitializeComponent();
        }

        private void btngetID_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionstring);
            con.Open();
            string sql = "SELECT Customer_ID FROM Customers WHERE First_Name ='" + txtFirstnamerecov.Text + "' and Last_Name ='" + txtlastnamerecov.Text + "' and Password = '" + txtpasswordrecov.Text + "'";
            command = new SqlCommand(sql, con);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                txtIDrecov.Text = datareader[0].ToString();
            }



            con.Close();
        }
    }
}// "SELECT Customer_ID FROM Customers WHERE First_Name = '" + txtFirstnamerecov + "'and Last_Name ='" + txtlastnamerecov + "'and Password ='" + txtpasswordrecov + "'";
