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
    public partial class formmovies : Form
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataReader datareader;
        string connectionstring = "Data Source=essql1.walton.uark.edu;Initial Catalog=ISYS4283F21TEAM07;User ID=ISYS4283F21TEAM07;password=GohogsUA1";
        public formmovies()
        {
            InitializeComponent();
        }

        private void formmovies_Load(object sender, EventArgs e)
        {   //populates listbox with movies that are currently available
            con = new SqlConnection(connectionstring);
            con.Open();
            string sql = "SELECT Title FROM Unit WHERE Media_Type='Movie'";
            command = new SqlCommand(sql, con);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                lstmovies.Items.Add(datareader[0].ToString());
            }
            con.Close();
            command.Dispose();
            datareader.Close();
        }

        private void lstmovies_SelectedIndexChanged(object sender, EventArgs e)
        {   //Populates information textboxes below the combobox based off which movie you select
            con = new SqlConnection(connectionstring);
            con.Open();
            string sql = "SELECT U.Tracking_Number, M.Genre, M.Publisher, D.First_Name, D.Last_Name, A.First_Name, A.Last_Name FROM Movies AS M Inner JOIN Director AS D ON M.Title_ID=D.Title_ID Inner Join Actor AS A ON M.Title_ID=A.Title_ID Inner Join Unit AS U ON M.Title_ID=U.Title_ID WHERE U.Title = '"  + lstmovies.SelectedItem.ToString() + "'";
            command = new SqlCommand(sql, con);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                lbltrackingm.Text = datareader[0].ToString();
                lblgenrem.Text = datareader[1].ToString();
                lblpublisherm.Text = datareader[2].ToString();
                lbldirectorm.Text = datareader[3].ToString();
                lbldirectorm.Text = datareader[3].ToString();
                lblactorm.Text = datareader[4].ToString();
                lblactorm.Text = datareader[4].ToString();

            }
            con.Close();
            command.Dispose();
            datareader.Close();
        }

        private void btnATCm_Click(object sender, EventArgs e)
        {   //Adds selected movie to Shopping Cart table
            try
            {
                con = new SqlConnection(connectionstring);
                con.Open();
                string sql = "INSERT INTO Shopping_Cart VALUES (@Customer_ID, @Tracking_Number, @Title)";
                int answer;
                command = new SqlCommand(sql, con);

                command.Parameters.AddWithValue("@Customer_ID", txtcustomeridm.Text);
                command.Parameters.AddWithValue("@Tracking_Number", lbltrackingm.Text);
                command.Parameters.AddWithValue("@Title", lstmovies.SelectedItem.ToString());


                answer = command.ExecuteNonQuery();

                con.Close();
                command.Dispose();
                MessageBox.Show("Movie Successfully added to cart!");
            }
            catch (Exception ex) { MessageBox.Show("Please Enter Customer ID Number Into Appropriate TextBox" + ex); }
        }
    }
    
}
