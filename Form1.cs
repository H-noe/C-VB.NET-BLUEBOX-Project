using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace TEAM07
{
    public partial class Form1 : Form
    {




        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

        );


        
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlnav.Height = btnmovies.Height;
            pnlnav.Top = btnmovies.Top;
            pnlnav.Left = btnmovies.Left;
            btnmovies.BackColor = Color.FromArgb(46, 51, 73);

            lblheader.Text = "Movies";
            this.pnlformloader.Controls.Clear();
            formmovies formmovies_Vrb = new formmovies() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formmovies_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlformloader.Controls.Add(formmovies_Vrb);
            formmovies_Vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnmovies_Click(object sender, EventArgs e)
        {
            pnlnav.Height = btnmovies.Height;
            pnlnav.Top = btnmovies.Top;
            pnlnav.Left = btnmovies.Left;
            btnmovies.BackColor = Color.FromArgb(46, 51, 73);

            lblheader.Text = "Movies";
            this.pnlformloader.Controls.Clear();
            formmovies formmovies_Vrb = new formmovies() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formmovies_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlformloader.Controls.Add(formmovies_Vrb);
            formmovies_Vrb.Show();
        }

        private void btngames_Click(object sender, EventArgs e)
        {
            pnlnav.Height = btngames.Height;
            pnlnav.Top = btngames.Top;
            btngames.BackColor = Color.FromArgb(46, 51, 73);

            lblheader.Text = "Games";
            this.pnlformloader.Controls.Clear();
            formgames formgames_Vrb = new formgames() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formgames_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlformloader.Controls.Add(formgames_Vrb);
            formgames_Vrb.Show();
        }

        private void btnaccount_Click(object sender, EventArgs e)
        {
            pnlnav.Height = btnaccount.Height;
            pnlnav.Top = btnaccount.Top;
            btnaccount.BackColor = Color.FromArgb(46, 51, 73);

            lblheader.Text = "Account";
            this.pnlformloader.Controls.Clear();
            formaccount formaccount_Vrb = new formaccount() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formaccount_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlformloader.Controls.Add(formaccount_Vrb);
            formaccount_Vrb.Show();

          //  connection = new SqlConnection(connectionstring);
           // connection.Open();
           // string sql = "SELECT Customer_ID,First_Name,Last_Name,Address,Phone_Number,Status,Membership_Type,Join_Date,Other_Users FROM Customers WHERE Last_Name = '" + txtfirstname.Text + "'and Customer_ID='" + txtID.Text + "'";
           // command = new SqlCommand(sql, connection);
          //  datareader = command.ExecuteReader();
          //  while (datareader.Read())
            {
              //  formaccount.txtcustomerida.Text = datareader[0].ToString();
              //  formaccount.txtfirstnamea.Text = datareader[1].ToString();
              //  formaccount.txtlastnamea.Text = datareader[2].ToString();
              //  formaccount.txtaddressa.Text = datareader[3].ToString();
              //  formaccount.txtphonenuma.Text = datareader[4].ToString();
              //  formaccount.txtstatusa.Text = datareader[5].ToString();
              //  formaccount.txtmembershiptypea.Text = datareader[6].ToString();
               // formaccount.txtjoindatea.Text = datareader[7].ToString();
              //  formaccount.txtotherusersa.Text = datareader[8].ToString();
            }
           // connection.Close();
           // command.Dispose();
            //datareader.Close();


        }

       

        private void btnlogout_Click(object sender, EventArgs e)
        {
            pnlnav.Height = btnlogout.Height;
            pnlnav.Top = btnlogout.Top;
            btnlogout.BackColor = Color.FromArgb(46, 51, 73);

            lblheader.Text = "Log Out";
            this.pnlformloader.Controls.Clear();
            formlogout formlogout_Vrb = new formlogout() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formlogout_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlformloader.Controls.Add(formlogout_Vrb);
            formlogout_Vrb.Show();

            MessageBox.Show("Logout Success...Come Again!");
            this.Hide();
            formlogin fm = new formlogin();
            fm.Show();
        }

        private void btnmovies_Leave(object sender, EventArgs e)
        {
            btnmovies.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btngames_Leave(object sender, EventArgs e)
        {
            btngames.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnaccount_Leave(object sender, EventArgs e)
        {
            btnaccount.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btncart_Click(object sender, EventArgs e)
        {
            pnlnav.Height = btncart.Height;
            pnlnav.Top = btncart.Top;
            btncart.BackColor = Color.FromArgb(46, 51, 73);

            lblheader.Text = "Cart";
            this.pnlformloader.Controls.Clear();
            formcart formcart_Vrb = new formcart() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formcart_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlformloader.Controls.Add(formcart_Vrb);
            formcart_Vrb.Show();
        }

        private void btncart_Leave(object sender, EventArgs e)
        {
            btncart.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnlogout_Leave(object sender, EventArgs e)
        {
            btnlogout.BackColor = Color.FromArgb(24, 30, 54);
        }

       
    }
}
