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
    public partial class formcart : Form
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataReader datareader;
        string connectionstring = "Data Source=essql1.walton.uark.edu;Initial Catalog=ISYS4283F21TEAM07;User ID=ISYS4283F21TEAM07;password=GohogsUA1";

        public formcart()
        {
            InitializeComponent();
        }

        private void formcart_Load(object sender, EventArgs e)
        {
           
        }

        private void btnloadcart_Click(object sender, EventArgs e)
        {   //Populated DGV with customers cart 
            con = new SqlConnection(connectionstring);
            con.Open();
            string sql = "SELECT Customer_ID, Tracking_Number, Title FROM Shopping_Cart WHERE Customer_ID = '" + txtcartid.Text + "'";
            var da = new SqlDataAdapter(sql, con);
            var ds = new DataSet();
            da.Fill(ds);
            {
                dgvcart.DataSource = ds.Tables[0];
            }
            con.Close();
            
            
        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionstring);
            con.Open();
            string sql = "INSERT INTO Rented(Customer_ID, Tracking_Number, Date_Due) SELECT Customer_ID, Tracking_Number, DATEADD(day, 7, GETDATE()) FROM Shopping_Cart WHERE Customer_ID ='" + txtcartid.Text + "' DELETE FROM Shopping_Cart WHERE Customer_ID ='" + txtcartid.Text + "'";
            command = new SqlCommand(sql, con);
            datareader = command.ExecuteReader();
            con.Close();

            MessageBox.Show("Items will be dispensed below. Come Again!");


        }
    }
}
