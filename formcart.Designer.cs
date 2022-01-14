
namespace TEAM07
{
    partial class formcart
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
            this.dgvcart = new System.Windows.Forms.DataGridView();
            this.txtcartid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btncheckout = new System.Windows.Forms.Button();
            this.btnloadcart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcart
            // 
            this.dgvcart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgvcart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcart.Location = new System.Drawing.Point(61, 21);
            this.dgvcart.Name = "dgvcart";
            this.dgvcart.Size = new System.Drawing.Size(591, 312);
            this.dgvcart.TabIndex = 0;
            // 
            // txtcartid
            // 
            this.txtcartid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtcartid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcartid.ForeColor = System.Drawing.SystemColors.Window;
            this.txtcartid.Location = new System.Drawing.Point(96, 377);
            this.txtcartid.Name = "txtcartid";
            this.txtcartid.Size = new System.Drawing.Size(240, 13);
            this.txtcartid.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.panel1.Location = new System.Drawing.Point(61, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 2);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(57, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID#";
            // 
            // btncheckout
            // 
            this.btncheckout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncheckout.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btncheckout.Location = new System.Drawing.Point(565, 357);
            this.btncheckout.Name = "btncheckout";
            this.btncheckout.Size = new System.Drawing.Size(87, 53);
            this.btncheckout.TabIndex = 27;
            this.btncheckout.Text = "Check Out";
            this.btncheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btncheckout.UseVisualStyleBackColor = true;
            this.btncheckout.Click += new System.EventHandler(this.btncheckout_Click);
            // 
            // btnloadcart
            // 
            this.btnloadcart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnloadcart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnloadcart.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloadcart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnloadcart.Location = new System.Drawing.Point(342, 368);
            this.btnloadcart.Name = "btnloadcart";
            this.btnloadcart.Size = new System.Drawing.Size(101, 30);
            this.btnloadcart.TabIndex = 28;
            this.btnloadcart.Text = "Update Cart";
            this.btnloadcart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnloadcart.UseVisualStyleBackColor = true;
            this.btnloadcart.Click += new System.EventHandler(this.btnloadcart_Click);
            // 
            // formcart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(717, 438);
            this.Controls.Add(this.btnloadcart);
            this.Controls.Add(this.btncheckout);
            this.Controls.Add(this.txtcartid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvcart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formcart";
            this.Text = "formcart";
            this.Load += new System.EventHandler(this.formcart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcart;
        private System.Windows.Forms.TextBox txtcartid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncheckout;
        private System.Windows.Forms.Button btnloadcart;
    }
}