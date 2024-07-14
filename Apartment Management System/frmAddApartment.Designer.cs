namespace Apartment_Management_System
{
    partial class frmAddApartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddApartment));
            this.txtSearchdetails = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbApartType = new System.Windows.Forms.ComboBox();
            this.txtNoLel = new System.Windows.Forms.TextBox();
            this.txtResNo = new System.Windows.Forms.TextBox();
            this.txtApaLocation = new System.Windows.Forms.TextBox();
            this.txtApaName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAvaUnit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblApaId = new System.Windows.Forms.Label();
            this.lblApaNo = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchdetails
            // 
            this.txtSearchdetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtSearchdetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchdetails.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchdetails.ForeColor = System.Drawing.Color.White;
            this.txtSearchdetails.HintForeColor = System.Drawing.Color.White;
            this.txtSearchdetails.HintText = "ENTER APA NO TO SEARCH";
            this.txtSearchdetails.isPassword = false;
            this.txtSearchdetails.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineIdleColor = System.Drawing.Color.Gold;
            this.txtSearchdetails.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.txtSearchdetails.LineThickness = 3;
            this.txtSearchdetails.Location = new System.Drawing.Point(599, 13);
            this.txtSearchdetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchdetails.Name = "txtSearchdetails";
            this.txtSearchdetails.Size = new System.Drawing.Size(212, 41);
            this.txtSearchdetails.TabIndex = 99;
            this.txtSearchdetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearchdetails);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lblEmpID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 68);
            this.panel2.TabIndex = 32;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::Apartment_Management_System.Properties.Resources.search1;
            this.btnSearch.Location = new System.Drawing.Point(817, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(41, 41);
            this.btnSearch.TabIndex = 100;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(26, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(247, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "Add Apartments";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.AutoScroll = true;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Controls.Add(this.lblApaId);
            this.bunifuGradientPanel1.Controls.Add(this.lblApaNo);
            this.bunifuGradientPanel1.Controls.Add(this.btnDelete);
            this.bunifuGradientPanel1.Controls.Add(this.btnCancel);
            this.bunifuGradientPanel1.Controls.Add(this.btnUpdate);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Aquamarine;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightGray;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 68);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(898, 556);
            this.bunifuGradientPanel1.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(128, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 22);
            this.label5.TabIndex = 69;
            this.label5.Text = "Apartment Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnCreateAcc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbApartType);
            this.panel1.Controls.Add(this.txtNoLel);
            this.panel1.Controls.Add(this.txtResNo);
            this.panel1.Controls.Add(this.txtApaLocation);
            this.panel1.Controls.Add(this.txtApaName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAvaUnit);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(93, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 227);
            this.panel1.TabIndex = 99;
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.BackColor = System.Drawing.Color.Cyan;
            this.btnCreateAcc.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnCreateAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnCreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAcc.ForeColor = System.Drawing.Color.Black;
            this.btnCreateAcc.Location = new System.Drawing.Point(506, 145);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCreateAcc.Size = new System.Drawing.Size(140, 40);
            this.btnCreateAcc.TabIndex = 94;
            this.btnCreateAcc.Text = "Add Apartment";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(39, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 19);
            this.label7.TabIndex = 134;
            this.label7.Text = "Apartment Name :-";
            // 
            // cmbApartType
            // 
            this.cmbApartType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cmbApartType.FormattingEnabled = true;
            this.cmbApartType.Location = new System.Drawing.Point(479, 76);
            this.cmbApartType.Name = "cmbApartType";
            this.cmbApartType.Size = new System.Drawing.Size(167, 27);
            this.cmbApartType.TabIndex = 127;
            // 
            // txtNoLel
            // 
            this.txtNoLel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoLel.Location = new System.Drawing.Point(44, 153);
            this.txtNoLel.Multiline = true;
            this.txtNoLel.Name = "txtNoLel";
            this.txtNoLel.Size = new System.Drawing.Size(105, 28);
            this.txtNoLel.TabIndex = 126;
            // 
            // txtResNo
            // 
            this.txtResNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResNo.Location = new System.Drawing.Point(164, 153);
            this.txtResNo.Multiline = true;
            this.txtResNo.Name = "txtResNo";
            this.txtResNo.Size = new System.Drawing.Size(188, 28);
            this.txtResNo.TabIndex = 126;
            // 
            // txtApaLocation
            // 
            this.txtApaLocation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApaLocation.Location = new System.Drawing.Point(285, 76);
            this.txtApaLocation.Multiline = true;
            this.txtApaLocation.Name = "txtApaLocation";
            this.txtApaLocation.Size = new System.Drawing.Size(179, 28);
            this.txtApaLocation.TabIndex = 126;
            // 
            // txtApaName
            // 
            this.txtApaName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApaName.Location = new System.Drawing.Point(43, 76);
            this.txtApaName.Multiline = true;
            this.txtApaName.Name = "txtApaName";
            this.txtApaName.Size = new System.Drawing.Size(227, 28);
            this.txtApaName.TabIndex = 126;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 131;
            this.label3.Text = "No of Levels :-";
            // 
            // txtAvaUnit
            // 
            this.txtAvaUnit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvaUnit.Location = new System.Drawing.Point(368, 153);
            this.txtAvaUnit.Multiline = true;
            this.txtAvaUnit.Name = "txtAvaUnit";
            this.txtAvaUnit.Size = new System.Drawing.Size(116, 28);
            this.txtAvaUnit.TabIndex = 129;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(160, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 19);
            this.label13.TabIndex = 131;
            this.label13.Text = "No of Residential Units :-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(475, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 132;
            this.label1.Text = "Apartment Type :-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(281, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 19);
            this.label14.TabIndex = 132;
            this.label14.Text = "Apartment Location :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(364, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 130;
            this.label2.Text = "Available Units:-";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(688, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 223);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 223);
            this.panel4.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 225);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(690, 2);
            this.panel6.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 2);
            this.panel3.TabIndex = 0;
            // 
            // lblApaId
            // 
            this.lblApaId.AutoSize = true;
            this.lblApaId.BackColor = System.Drawing.Color.Transparent;
            this.lblApaId.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.lblApaId.ForeColor = System.Drawing.Color.Black;
            this.lblApaId.Location = new System.Drawing.Point(166, 37);
            this.lblApaId.Name = "lblApaId";
            this.lblApaId.Size = new System.Drawing.Size(20, 23);
            this.lblApaId.TabIndex = 74;
            this.lblApaId.Text = "0";
            // 
            // lblApaNo
            // 
            this.lblApaNo.AutoSize = true;
            this.lblApaNo.BackColor = System.Drawing.Color.Transparent;
            this.lblApaNo.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApaNo.ForeColor = System.Drawing.Color.Black;
            this.lblApaNo.Location = new System.Drawing.Point(35, 37);
            this.lblApaNo.Name = "lblApaNo";
            this.lblApaNo.Size = new System.Drawing.Size(132, 22);
            this.lblApaNo.TabIndex = 69;
            this.lblApaNo.Text = "Apartment ID #";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(378, 432);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(119, 40);
            this.btnDelete.TabIndex = 94;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(572, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(119, 40);
            this.btnCancel.TabIndex = 93;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(192, 432);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdate.Size = new System.Drawing.Size(119, 40);
            this.btnUpdate.TabIndex = 97;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpID.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.ForeColor = System.Drawing.Color.Black;
            this.lblEmpID.Location = new System.Drawing.Point(374, 27);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(0, 22);
            this.lblEmpID.TabIndex = 69;
            // 
            // frmAddApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 624);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmAddApartment";
            this.Text = "frmAddApartment";
            this.Load += new System.EventHandler(this.frmAddApartment_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbApartType;
        private System.Windows.Forms.TextBox txtResNo;
        private System.Windows.Forms.TextBox txtApaName;
        private System.Windows.Forms.TextBox txtAvaUnit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lblApaId;
        private System.Windows.Forms.Label lblApaNo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateAcc;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchdetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtApaLocation;
        private System.Windows.Forms.TextBox txtNoLel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmpID;
    }
}