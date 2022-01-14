
namespace TEAM07
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btncart = new System.Windows.Forms.Button();
            this.btnaccount = new System.Windows.Forms.Button();
            this.btngames = new System.Windows.Forms.Button();
            this.btnmovies = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlnav = new System.Windows.Forms.Panel();
            this.Lblusername = new System.Windows.Forms.Label();
            this.lblheader = new System.Windows.Forms.Label();
            this.pnlformloader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btncart);
            this.panel1.Controls.Add(this.btnaccount);
            this.panel1.Controls.Add(this.btngames);
            this.panel1.Controls.Add(this.btnmovies);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // btnlogout
            // 
            this.btnlogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnlogout.Location = new System.Drawing.Point(0, 535);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(186, 42);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            this.btnlogout.Leave += new System.EventHandler(this.btnlogout_Leave);
            // 
            // btncart
            // 
            this.btncart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncart.FlatAppearance.BorderSize = 0;
            this.btncart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncart.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btncart.Image = ((System.Drawing.Image)(resources.GetObject("btncart.Image")));
            this.btncart.Location = new System.Drawing.Point(0, 330);
            this.btncart.Name = "btncart";
            this.btncart.Size = new System.Drawing.Size(186, 62);
            this.btncart.TabIndex = 5;
            this.btncart.Text = "Cart";
            this.btncart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btncart.UseVisualStyleBackColor = true;
            this.btncart.Click += new System.EventHandler(this.btncart_Click);
            this.btncart.Leave += new System.EventHandler(this.btncart_Leave);
            // 
            // btnaccount
            // 
            this.btnaccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnaccount.FlatAppearance.BorderSize = 0;
            this.btnaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaccount.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnaccount.Image = ((System.Drawing.Image)(resources.GetObject("btnaccount.Image")));
            this.btnaccount.Location = new System.Drawing.Point(0, 268);
            this.btnaccount.Name = "btnaccount";
            this.btnaccount.Size = new System.Drawing.Size(186, 62);
            this.btnaccount.TabIndex = 4;
            this.btnaccount.Text = "Account";
            this.btnaccount.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnaccount.UseVisualStyleBackColor = true;
            this.btnaccount.Click += new System.EventHandler(this.btnaccount_Click);
            this.btnaccount.Leave += new System.EventHandler(this.btnaccount_Leave);
            // 
            // btngames
            // 
            this.btngames.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngames.FlatAppearance.BorderSize = 0;
            this.btngames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngames.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btngames.Image = ((System.Drawing.Image)(resources.GetObject("btngames.Image")));
            this.btngames.Location = new System.Drawing.Point(0, 206);
            this.btngames.Name = "btngames";
            this.btngames.Size = new System.Drawing.Size(186, 62);
            this.btngames.TabIndex = 3;
            this.btngames.Text = "Games";
            this.btngames.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btngames.UseVisualStyleBackColor = true;
            this.btngames.Click += new System.EventHandler(this.btngames_Click);
            this.btngames.Leave += new System.EventHandler(this.btngames_Leave);
            // 
            // btnmovies
            // 
            this.btnmovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmovies.FlatAppearance.BorderSize = 0;
            this.btnmovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmovies.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmovies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnmovies.Image = ((System.Drawing.Image)(resources.GetObject("btnmovies.Image")));
            this.btnmovies.Location = new System.Drawing.Point(0, 144);
            this.btnmovies.Name = "btnmovies";
            this.btnmovies.Size = new System.Drawing.Size(186, 62);
            this.btnmovies.TabIndex = 2;
            this.btnmovies.Text = "Movies";
            this.btnmovies.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnmovies.UseVisualStyleBackColor = true;
            this.btnmovies.Click += new System.EventHandler(this.btnmovies_Click);
            this.btnmovies.Leave += new System.EventHandler(this.btnmovies_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pnlnav);
            this.panel2.Controls.Add(this.Lblusername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 134);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pnlnav
            // 
            this.pnlnav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlnav.Location = new System.Drawing.Point(0, 193);
            this.pnlnav.Name = "pnlnav";
            this.pnlnav.Size = new System.Drawing.Size(3, 100);
            this.pnlnav.TabIndex = 2;
            // 
            // Lblusername
            // 
            this.Lblusername.AutoSize = true;
            this.Lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblusername.Location = new System.Drawing.Point(31, 100);
            this.Lblusername.Name = "Lblusername";
            this.Lblusername.Size = new System.Drawing.Size(116, 16);
            this.Lblusername.TabIndex = 0;
            this.Lblusername.Text = "Welcome Back!";
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblheader.Location = new System.Drawing.Point(205, 36);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(125, 31);
            this.lblheader.TabIndex = 1;
            this.lblheader.Text = "MOVIES";
            // 
            // pnlformloader
            // 
            this.pnlformloader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlformloader.Location = new System.Drawing.Point(186, 100);
            this.pnlformloader.Name = "pnlformloader";
            this.pnlformloader.Size = new System.Drawing.Size(765, 477);
            this.pnlformloader.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.pnlformloader);
            this.Controls.Add(this.lblheader);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btncart;
        private System.Windows.Forms.Button btnaccount;
        private System.Windows.Forms.Button btngames;
        private System.Windows.Forms.Button btnmovies;
        private System.Windows.Forms.Label Lblusername;
        private System.Windows.Forms.Panel pnlnav;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlformloader;
    }
}

