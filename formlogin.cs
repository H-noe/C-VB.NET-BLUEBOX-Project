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
    public partial class formlogin : Form
    {
        SqlConnection con = new SqlConnection();
      
        public formlogin()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=essql1.walton.uark.edu;Initial Catalog=ISYS4283F21TEAM07;User ID=ISYS4283F21TEAM07;password=GohogsUA1";

            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {   //Confirmes user has row in Customers table and logs them in
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=essql1.walton.uark.edu;Initial Catalog=ISYS4283F21TEAM07;User ID=ISYS4283F21TEAM07;password=GohogsUA1";
                con.Open();
                string Customer_ID = txtidnumber.Text;
                string Password = txtpassword.Text;
                SqlCommand cmd = new SqlCommand("SELECT Customer_ID, Password FROM Customers WHERE Customer_ID='" + txtidnumber.Text + "'and Password='" + txtpassword.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Success");
                    this.Hide();
                    Form1 fm = new Form1();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Login please check User ID# and Password");
                }
                con.Close();
            } catch (Exception ex) { MessageBox.Show("User was not found. Ensure your Customer ID# and Password are correct!" + ex); }

        }

        private void btncreateaccount_Click(object sender, EventArgs e)
        {
            FormCreateAccount fm = new FormCreateAccount();
            fm.Show();
        }

        private void btnforogtID_Click(object sender, EventArgs e)
        {
            ForogtID fm = new ForogtID();
            fm.Show();
        }
    }
}
