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
    public partial class formgames : Form
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataReader datareader;
        string connectionstring = "Data Source=essql1.walton.uark.edu;Initial Catalog=ISYS4283F21TEAM07;User ID=ISYS4283F21TEAM07;password=GohogsUA1";
        public formgames()
        {
            InitializeComponent();
        }

        private void formgames_Load(object sender, EventArgs e)
        {   //Populates game combobox with games that are currently available
            con = new SqlConnection(connectionstring);
            con.Open();
            string sql = "SELECT Title FROM Unit WHERE Media_Type='Game'";
            command = new SqlCommand(sql, con);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                lstgames.Items.Add(datareader[0].ToString());
            }
            con.Close();
            command.Dispose();
            datareader.Close();
        }

        private void lstgames_SelectedIndexChanged(object sender, EventArgs e)
        {   //Populates game information textboxes below the combobox
            con.Open();
            string sql = "SELECT U.Tracking_Number, G.Genre, Publisher, G.Platform, G.Max_Players FROM Games AS G Inner Join Title AS T ON G.Title_ID = T.Title_ID Inner Join Unit AS U ON G.Title_ID = U.Title_ID WHERE U.Title= '" + lstgames.SelectedItem.ToString() + "'";
            command = new SqlCommand(sql, con);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                lbltrackingg.Text = datareader[0].ToString();
                lblgenrea.Text = datareader[1].ToString();
                lblpublishera.Text = datareader[2].ToString();
                lblplatform.Text = datareader[3].ToString();
                lblmaxplayers.Text = datareader[4].ToString();
             

            }
            con.Close();
            command.Dispose();
            datareader.Close();
        }

        private void btnATCg_Click(object sender, EventArgs e)
        { try
            {   //Adds selected game to cart and Shopping_Cart table
                con = new SqlConnection(connectionstring);
                con.Open();
                string sql = "INSERT INTO Shopping_Cart VALUES (@Customer_ID, @Tracking_Number, @Title)";
                int answer;
                command = new SqlCommand(sql, con);

                command.Parameters.AddWithValue("@Customer_ID", txtcustomeridg.Text);
                command.Parameters.AddWithValue("@Tracking_Number", lbltrackingg.Text);
                command.Parameters.AddWithValue("@Title", lstgames.SelectedItem.ToString());


                answer = command.ExecuteNonQuery();

                con.Close();
                command.Dispose();
                MessageBox.Show("Game Successfully added to cart!");
            } catch(Exception ex) { MessageBox.Show("Please Enter Customer ID Number Into Appropriate TextBox" + ex); }
        }
    }
}
