namespace Apartment_Management_System
{
    partial class frmEditTenant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditTenant));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchdetails = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtT = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtTenFn = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTenLn = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblRegDate = new System.Windows.Forms.Label();
            this.lblda = new System.Windows.Forms.Label();
            this.txtResID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblNic = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblFn = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTenId = new System.Windows.Forms.Label();
            this.lblTenNo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearchdetails);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 68);
            this.panel2.TabIndex = 33;
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearchDetails_Click);
            // 
            // txtSearchdetails
            // 
            this.txtSearchdetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtSearchdetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchdetails.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchdetails.ForeColor = System.Drawing.Color.White;
            this.txtSearchdetails.HintForeColor = System.Drawing.Color.White;
            this.txtSearchdetails.HintText = "ENTER TENANT ID TO SEARCH";
            this.txtSearchdetails.isPassword = false;
            this.txtSearchdetails.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineIdleColor = System.Drawing.Color.Gold;
            this.txtSearchdetails.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.txtSearchdetails.LineThickness = 3;
            this.txtSearchdetails.Location = new System.Drawing.Point(573, 13);
            this.txtSearchdetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchdetails.Name = "txtSearchdetails";
            this.txtSearchdetails.Size = new System.Drawing.Size(238, 41);
            this.txtSearchdetails.TabIndex = 99;
            this.txtSearchdetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(26, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(298, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "Edit Tenant Details";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.AutoScroll = true;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnDelete);
            this.bunifuGradientPanel1.Controls.Add(this.btnClear);
            this.bunifuGradientPanel1.Controls.Add(this.btnUpdate);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Controls.Add(this.lblTenId);
            this.bunifuGradientPanel1.Controls.Add(this.lblTenNo);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Olive;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkTurquoise;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LightGray;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.LightPink;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 68);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(898, 556);
            this.bunifuGradientPanel1.TabIndex = 35;
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "DELETE";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = null;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(630, 430);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.LightCoral;
            this.btnDelete.OnHovercolor = System.Drawing.Color.Thistle;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(177, 43);
            this.btnDelete.TabIndex = 141;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.Black;
            this.btnDelete.TextFont = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnClear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.BorderRadius = 0;
            this.btnClear.ButtonText = "CLEAR";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledColor = System.Drawing.Color.Gray;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClear.Iconimage = null;
            this.btnClear.Iconimage_right = null;
            this.btnClear.Iconimage_right_Selected = null;
            this.btnClear.Iconimage_Selected = null;
            this.btnClear.IconMarginLeft = 0;
            this.btnClear.IconMarginRight = 0;
            this.btnClear.IconRightVisible = true;
            this.btnClear.IconRightZoom = 0D;
            this.btnClear.IconVisible = true;
            this.btnClear.IconZoom = 90D;
            this.btnClear.IsTab = false;
            this.btnClear.Location = new System.Drawing.Point(199, 430);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.btnClear.OnHovercolor = System.Drawing.Color.MediumAquamarine;
            this.btnClear.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnClear.selected = false;
            this.btnClear.Size = new System.Drawing.Size(177, 43);
            this.btnClear.TabIndex = 142;
            this.btnClear.Text = "CLEAR";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Textcolor = System.Drawing.Color.Black;
            this.btnClear.TextFont = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.ButtonText = "UPDATE";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = null;
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 90D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(418, 430);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.OnHovercolor = System.Drawing.Color.MediumSlateBlue;
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(177, 43);
            this.btnUpdate.TabIndex = 142;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.Color.Black;
            this.btnUpdate.TextFont = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(57, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 22);
            this.label5.TabIndex = 69;
            this.label5.Text = "Tenant Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtT);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.txtTenFn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txtTenLn);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.lblRegDate);
            this.panel1.Controls.Add(this.lblda);
            this.panel1.Controls.Add(this.txtResID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNic);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txtMobile);
            this.panel1.Controls.Add(this.lblNic);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblFn);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Location = new System.Drawing.Point(34, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 269);
            this.panel1.TabIndex = 99;
            // 
            // txtT
            // 
            this.txtT.AutoSize = true;
            this.txtT.BackColor = System.Drawing.Color.Transparent;
            this.txtT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtT.ForeColor = System.Drawing.Color.Black;
            this.txtT.Location = new System.Drawing.Point(207, 74);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(104, 19);
            this.txtT.TabIndex = 136;
            this.txtT.Text = "Tenant Title :-";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(800, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 265);
            this.panel5.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(211, 101);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(131, 28);
            this.txtTitle.TabIndex = 125;
            // 
            // txtTenFn
            // 
            this.txtTenFn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenFn.Location = new System.Drawing.Point(375, 101);
            this.txtTenFn.Multiline = true;
            this.txtTenFn.Name = "txtTenFn";
            this.txtTenFn.Size = new System.Drawing.Size(186, 28);
            this.txtTenFn.TabIndex = 125;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 265);
            this.panel4.TabIndex = 1;
            // 
            // txtTenLn
            // 
            this.txtTenLn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLn.Location = new System.Drawing.Point(585, 101);
            this.txtTenLn.Multiline = true;
            this.txtTenLn.Name = "txtTenLn";
            this.txtTenLn.Size = new System.Drawing.Size(188, 28);
            this.txtTenLn.TabIndex = 129;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 267);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(802, 2);
            this.panel6.TabIndex = 0;
            // 
            // lblRegDate
            // 
            this.lblRegDate.AutoSize = true;
            this.lblRegDate.BackColor = System.Drawing.Color.Transparent;
            this.lblRegDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblRegDate.ForeColor = System.Drawing.Color.Black;
            this.lblRegDate.Location = new System.Drawing.Point(666, 17);
            this.lblRegDate.Name = "lblRegDate";
            this.lblRegDate.Size = new System.Drawing.Size(91, 19);
            this.lblRegDate.TabIndex = 134;
            this.lblRegDate.Text = "yyyy-mm-dd";
            // 
            // lblda
            // 
            this.lblda.AutoSize = true;
            this.lblda.BackColor = System.Drawing.Color.Transparent;
            this.lblda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblda.ForeColor = System.Drawing.Color.Black;
            this.lblda.Location = new System.Drawing.Point(535, 17);
            this.lblda.Name = "lblda";
            this.lblda.Size = new System.Drawing.Size(125, 19);
            this.lblda.TabIndex = 134;
            this.lblda.Text = "Registered Date:";
            // 
            // txtResID
            // 
            this.txtResID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResID.Location = new System.Drawing.Point(36, 101);
            this.txtResID.Multiline = true;
            this.txtResID.Name = "txtResID";
            this.txtResID.ReadOnly = true;
            this.txtResID.Size = new System.Drawing.Size(152, 28);
            this.txtResID.TabIndex = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 134;
            this.label1.Text = "Resident ID :";
            // 
            // txtNic
            // 
            this.txtNic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNic.Location = new System.Drawing.Point(36, 203);
            this.txtNic.Multiline = true;
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(190, 28);
            this.txtNic.TabIndex = 130;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(802, 2);
            this.panel3.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(581, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 19);
            this.label21.TabIndex = 133;
            this.label21.Text = "Last Name :-";
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(289, 203);
            this.txtMobile.Multiline = true;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(182, 28);
            this.txtMobile.TabIndex = 128;
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.BackColor = System.Drawing.Color.Transparent;
            this.lblNic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblNic.ForeColor = System.Drawing.Color.Black;
            this.lblNic.Location = new System.Drawing.Point(32, 175);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(76, 19);
            this.lblNic.TabIndex = 134;
            this.lblNic.Text = "NIC No :-";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(539, 203);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 28);
            this.txtEmail.TabIndex = 127;
            // 
            // lblFn
            // 
            this.lblFn.AutoSize = true;
            this.lblFn.BackColor = System.Drawing.Color.Transparent;
            this.lblFn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblFn.ForeColor = System.Drawing.Color.Black;
            this.lblFn.Location = new System.Drawing.Point(371, 73);
            this.lblFn.Name = "lblFn";
            this.lblFn.Size = new System.Drawing.Size(98, 19);
            this.lblFn.TabIndex = 135;
            this.lblFn.Text = "First Name :-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(285, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 19);
            this.label13.TabIndex = 132;
            this.label13.Text = "Contact Number :-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(535, 175);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 19);
            this.label17.TabIndex = 131;
            this.label17.Text = "Email :-";
            // 
            // lblTenId
            // 
            this.lblTenId.AutoSize = true;
            this.lblTenId.BackColor = System.Drawing.Color.Transparent;
            this.lblTenId.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.lblTenId.ForeColor = System.Drawing.Color.Black;
            this.lblTenId.Location = new System.Drawing.Point(154, 40);
            this.lblTenId.Name = "lblTenId";
            this.lblTenId.Size = new System.Drawing.Size(106, 23);
            this.lblTenId.TabIndex = 74;
            this.lblTenId.Text = "TEN/00000";
            // 
            // lblTenNo
            // 
            this.lblTenNo.AutoSize = true;
            this.lblTenNo.BackColor = System.Drawing.Color.Transparent;
            this.lblTenNo.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNo.ForeColor = System.Drawing.Color.Black;
            this.lblTenNo.Location = new System.Drawing.Point(44, 40);
            this.lblTenNo.Name = "lblTenNo";
            this.lblTenNo.Size = new System.Drawing.Size(102, 22);
            this.lblTenNo.TabIndex = 69;
            this.lblTenNo.Text = "Tenant ID #";
            // 
            // frmEditTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 624);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmEditTenant";
            this.Text = "frmEditTenant";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchdetails;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtT;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtTenFn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTenLn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtResID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNic;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblNic;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label lblTenId;
        private System.Windows.Forms.Label lblTenNo;
        private System.Windows.Forms.Label lblRegDate;
        private System.Windows.Forms.Label lblda;
        private Bunifu.Framework.UI.BunifuFlatButton btnClear;
        private System.Windows.Forms.TextBox txtTitle;
    }
}