namespace Apartment_Management_System
{
    partial class frmDashBoardAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashBoardAdmin));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRentedUnits = new System.Windows.Forms.Label();
            this.lblSoldUnits = new System.Windows.Forms.Label();
            this.lblAvaiUnits = new System.Windows.Forms.Label();
            this.lblTotUsers = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblday = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbldate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblhrs = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Controls.Add(this.lblRentedUnits);
            this.bunifuGradientPanel1.Controls.Add(this.lblSoldUnits);
            this.bunifuGradientPanel1.Controls.Add(this.lblAvaiUnits);
            this.bunifuGradientPanel1.Controls.Add(this.lblTotUsers);
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.lable);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.lblday);
            this.bunifuGradientPanel1.Controls.Add(this.lbldate);
            this.bunifuGradientPanel1.Controls.Add(this.lblhrs);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(884, 624);
            this.bunifuGradientPanel1.TabIndex = 9;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 599);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 25);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(566, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "All Rights Reserved © ABC Apartments (PVT) LTD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRentedUnits
            // 
            this.lblRentedUnits.AutoSize = true;
            this.lblRentedUnits.BackColor = System.Drawing.Color.Transparent;
            this.lblRentedUnits.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.lblRentedUnits.ForeColor = System.Drawing.Color.White;
            this.lblRentedUnits.Location = new System.Drawing.Point(783, 524);
            this.lblRentedUnits.Name = "lblRentedUnits";
            this.lblRentedUnits.Size = new System.Drawing.Size(47, 32);
            this.lblRentedUnits.TabIndex = 13;
            this.lblRentedUnits.Text = "25";
            this.lblRentedUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRentedUnits.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblSoldUnits
            // 
            this.lblSoldUnits.AutoSize = true;
            this.lblSoldUnits.BackColor = System.Drawing.Color.Transparent;
            this.lblSoldUnits.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.lblSoldUnits.ForeColor = System.Drawing.Color.White;
            this.lblSoldUnits.Location = new System.Drawing.Point(783, 441);
            this.lblSoldUnits.Name = "lblSoldUnits";
            this.lblSoldUnits.Size = new System.Drawing.Size(47, 32);
            this.lblSoldUnits.TabIndex = 13;
            this.lblSoldUnits.Text = "45";
            this.lblSoldUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSoldUnits.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblAvaiUnits
            // 
            this.lblAvaiUnits.AutoSize = true;
            this.lblAvaiUnits.BackColor = System.Drawing.Color.Transparent;
            this.lblAvaiUnits.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.lblAvaiUnits.ForeColor = System.Drawing.Color.White;
            this.lblAvaiUnits.Location = new System.Drawing.Point(783, 359);
            this.lblAvaiUnits.Name = "lblAvaiUnits";
            this.lblAvaiUnits.Size = new System.Drawing.Size(47, 32);
            this.lblAvaiUnits.TabIndex = 13;
            this.lblAvaiUnits.Text = "75";
            this.lblAvaiUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAvaiUnits.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTotUsers
            // 
            this.lblTotUsers.AutoSize = true;
            this.lblTotUsers.BackColor = System.Drawing.Color.Transparent;
            this.lblTotUsers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.lblTotUsers.ForeColor = System.Drawing.Color.White;
            this.lblTotUsers.Location = new System.Drawing.Point(783, 265);
            this.lblTotUsers.Name = "lblTotUsers";
            this.lblTotUsers.Size = new System.Drawing.Size(47, 32);
            this.lblTotUsers.TabIndex = 13;
            this.lblTotUsers.Text = "02";
            this.lblTotUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotUsers.Click += new System.EventHandler(this.lblJobsNo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(603, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rented Residential Units";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(627, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sold Residential Units";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(582, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Available Residential Units";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.BackColor = System.Drawing.Color.Transparent;
            this.lable.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.Color.White;
            this.lable.Location = new System.Drawing.Point(653, 228);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(194, 27);
            this.lable.TabIndex = 10;
            this.lable.Text = "Total System Users";
            this.lable.Click += new System.EventHandler(this.lable_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Apartment_Management_System.Properties.Resources.abcApartments_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(107, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.BackColor = System.Drawing.Color.Transparent;
            this.lblday.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblday.ForeColor = System.Drawing.Color.White;
            this.lblday.Location = new System.Drawing.Point(720, 106);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(127, 32);
            this.lblday.TabIndex = 0;
            this.lblday.Text = "Saturday";
            this.lblday.Click += new System.EventHandler(this.lblday_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.White;
            this.lbldate.Location = new System.Drawing.Point(546, 106);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(179, 32);
            this.lbldate.TabIndex = 6;
            this.lbldate.Text = "Mar 09 2020,";
            this.lbldate.Click += new System.EventHandler(this.lbldate_Click);
            // 
            // lblhrs
            // 
            this.lblhrs.AutoSize = true;
            this.lblhrs.BackColor = System.Drawing.Color.Transparent;
            this.lblhrs.Font = new System.Drawing.Font("Times New Roman", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhrs.ForeColor = System.Drawing.Color.White;
            this.lblhrs.Location = new System.Drawing.Point(510, 20);
            this.lblhrs.Name = "lblhrs";
            this.lblhrs.Size = new System.Drawing.Size(364, 98);
            this.lblhrs.TabIndex = 7;
            this.lblhrs.Text = "04:30:50";
            this.lblhrs.Click += new System.EventHandler(this.lblhrs_Click);
            // 
            // frmDashBoardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 624);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashBoardAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashBoardAdmin";
            this.Load += new System.EventHandler(this.frmDashBoardAdmin_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotUsers;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblday;
        private Bunifu.Framework.UI.BunifuCustomLabel lbldate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblhrs;
        private System.Windows.Forms.Label lblRentedUnits;
        private System.Windows.Forms.Label lblSoldUnits;
        private System.Windows.Forms.Label lblAvaiUnits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}