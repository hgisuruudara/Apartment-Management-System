namespace Apartment_Management_System
{
    partial class frmAddResident
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddResident));
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchdetails = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.cmbApartNa = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbApartType = new System.Windows.Forms.ComboBox();
            this.txtApartLocation = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtApartmentID = new System.Windows.Forms.TextBox();
            this.btnPay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtNoLevels = new System.Windows.Forms.TextBox();
            this.txtNoofUnits = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAvailUnits = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblApaNo = new System.Windows.Forms.Label();
            this.lblResId = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtResiStatus = new System.Windows.Forms.TextBox();
            this.txtNoofBath = new System.Windows.Forms.TextBox();
            this.txtBlockNa = new System.Windows.Forms.TextBox();
            this.txtResiNa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNoofRooms = new System.Windows.Forms.TextBox();
            this.txtRentPri = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPurPrice = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(26, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "Add Resident";
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
            this.panel2.TabIndex = 34;
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
            // txtSearchdetails
            // 
            this.txtSearchdetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtSearchdetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchdetails.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchdetails.ForeColor = System.Drawing.Color.White;
            this.txtSearchdetails.HintForeColor = System.Drawing.Color.White;
            this.txtSearchdetails.HintText = "ENTER RES ID TO SEARCH";
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
            this.btnUpdate.Location = new System.Drawing.Point(308, 805);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdate.Size = new System.Drawing.Size(119, 40);
            this.btnUpdate.TabIndex = 97;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnCreateAcc.Location = new System.Drawing.Point(138, 805);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCreateAcc.Size = new System.Drawing.Size(133, 40);
            this.btnCreateAcc.TabIndex = 94;
            this.btnCreateAcc.Text = "Add Resident";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(386, 887);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 131;
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
            this.btnCancel.Location = new System.Drawing.Point(636, 805);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(119, 40);
            this.btnCancel.TabIndex = 93;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(475, 805);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(119, 40);
            this.btnDelete.TabIndex = 94;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.cmbApartNa);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.cmbApartType);
            this.panel1.Controls.Add(this.txtApartLocation);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txtApartmentID);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.txtNoLevels);
            this.panel1.Controls.Add(this.txtNoofUnits);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAvailUnits);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(102, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 357);
            this.panel1.TabIndex = 133;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(33, 168);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(156, 19);
            this.label26.TabIndex = 156;
            this.label26.Text = "Apartment Location :-";
            // 
            // cmbApartNa
            // 
            this.cmbApartNa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApartNa.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cmbApartNa.FormattingEnabled = true;
            this.cmbApartNa.Location = new System.Drawing.Point(258, 124);
            this.cmbApartNa.Name = "cmbApartNa";
            this.cmbApartNa.Size = new System.Drawing.Size(197, 27);
            this.cmbApartNa.TabIndex = 153;
            this.cmbApartNa.SelectedIndexChanged += new System.EventHandler(this.cmbApartNa_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(254, 92);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(182, 19);
            this.label27.TabIndex = 152;
            this.label27.Text = "Select Apartment Name :-";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(481, 92);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(116, 19);
            this.label23.TabIndex = 157;
            this.label23.Text = "Apartment ID :-";
            // 
            // cmbApartType
            // 
            this.cmbApartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApartType.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cmbApartType.FormattingEnabled = true;
            this.cmbApartType.Location = new System.Drawing.Point(35, 125);
            this.cmbApartType.Name = "cmbApartType";
            this.cmbApartType.Size = new System.Drawing.Size(192, 27);
            this.cmbApartType.TabIndex = 151;
            this.cmbApartType.SelectedIndexChanged += new System.EventHandler(this.cmbApartType_SelectedIndexChanged);
            // 
            // txtApartLocation
            // 
            this.txtApartLocation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApartLocation.Location = new System.Drawing.Point(37, 199);
            this.txtApartLocation.Multiline = true;
            this.txtApartLocation.Name = "txtApartLocation";
            this.txtApartLocation.ReadOnly = true;
            this.txtApartLocation.Size = new System.Drawing.Size(192, 28);
            this.txtApartLocation.TabIndex = 155;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(31, 93);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(175, 19);
            this.label19.TabIndex = 150;
            this.label19.Text = "Select Apartment Type :-";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // txtApartmentID
            // 
            this.txtApartmentID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApartmentID.Location = new System.Drawing.Point(485, 123);
            this.txtApartmentID.Multiline = true;
            this.txtApartmentID.Name = "txtApartmentID";
            this.txtApartmentID.ReadOnly = true;
            this.txtApartmentID.Size = new System.Drawing.Size(178, 28);
            this.txtApartmentID.TabIndex = 154;
            // 
            // btnPay
            // 
            this.btnPay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPay.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPay.BorderRadius = 0;
            this.btnPay.ButtonText = "View Apartment Details";
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.DisabledColor = System.Drawing.Color.Gray;
            this.btnPay.Font = new System.Drawing.Font("Poplar Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPay.Iconimage = null;
            this.btnPay.Iconimage_right = null;
            this.btnPay.Iconimage_right_Selected = null;
            this.btnPay.Iconimage_Selected = null;
            this.btnPay.IconMarginLeft = 0;
            this.btnPay.IconMarginRight = 0;
            this.btnPay.IconRightVisible = true;
            this.btnPay.IconRightZoom = 0D;
            this.btnPay.IconVisible = true;
            this.btnPay.IconZoom = 90D;
            this.btnPay.IsTab = false;
            this.btnPay.Location = new System.Drawing.Point(34, 36);
            this.btnPay.Margin = new System.Windows.Forms.Padding(6);
            this.btnPay.Name = "btnPay";
            this.btnPay.Normalcolor = System.Drawing.Color.MediumVioletRed;
            this.btnPay.OnHovercolor = System.Drawing.Color.Crimson;
            this.btnPay.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPay.selected = false;
            this.btnPay.Size = new System.Drawing.Size(207, 35);
            this.btnPay.TabIndex = 149;
            this.btnPay.Text = "View Apartment Details";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPay.Textcolor = System.Drawing.Color.White;
            this.btnPay.TextFont = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtNoLevels
            // 
            this.txtNoLevels.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoLevels.Location = new System.Drawing.Point(258, 199);
            this.txtNoLevels.Multiline = true;
            this.txtNoLevels.Name = "txtNoLevels";
            this.txtNoLevels.ReadOnly = true;
            this.txtNoLevels.Size = new System.Drawing.Size(120, 28);
            this.txtNoLevels.TabIndex = 136;
            // 
            // txtNoofUnits
            // 
            this.txtNoofUnits.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoofUnits.Location = new System.Drawing.Point(35, 283);
            this.txtNoofUnits.Multiline = true;
            this.txtNoofUnits.Name = "txtNoofUnits";
            this.txtNoofUnits.ReadOnly = true;
            this.txtNoofUnits.Size = new System.Drawing.Size(188, 28);
            this.txtNoofUnits.TabIndex = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(254, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 143;
            this.label1.Text = "No of Levels :-";
            // 
            // txtAvailUnits
            // 
            this.txtAvailUnits.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailUnits.Location = new System.Drawing.Point(262, 283);
            this.txtAvailUnits.Multiline = true;
            this.txtAvailUnits.Name = "txtAvailUnits";
            this.txtAvailUnits.ReadOnly = true;
            this.txtAvailUnits.Size = new System.Drawing.Size(116, 28);
            this.txtAvailUnits.TabIndex = 141;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(485, 194);
            this.btnClear.Name = "btnClear";
            this.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClear.Size = new System.Drawing.Size(168, 41);
            this.btnClear.TabIndex = 93;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(34, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 19);
            this.label13.TabIndex = 144;
            this.label13.Text = "No of Residential Units :-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(258, 252);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 19);
            this.label17.TabIndex = 142;
            this.label17.Text = "Available Units:-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(329, -27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 134;
            this.label4.Text = "Apartment ID :-";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(688, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 353);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 353);
            this.panel4.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 355);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(137, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 22);
            this.label5.TabIndex = 132;
            this.label5.Text = "Apartment Details";
            // 
            // lblApaNo
            // 
            this.lblApaNo.AutoSize = true;
            this.lblApaNo.BackColor = System.Drawing.Color.Transparent;
            this.lblApaNo.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApaNo.ForeColor = System.Drawing.Color.Black;
            this.lblApaNo.Location = new System.Drawing.Point(41, 439);
            this.lblApaNo.Name = "lblApaNo";
            this.lblApaNo.Size = new System.Drawing.Size(119, 22);
            this.lblApaNo.TabIndex = 134;
            this.lblApaNo.Text = "Resident ID #";
            // 
            // lblResId
            // 
            this.lblResId.AutoSize = true;
            this.lblResId.BackColor = System.Drawing.Color.Transparent;
            this.lblResId.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.lblResId.ForeColor = System.Drawing.Color.Black;
            this.lblResId.Location = new System.Drawing.Point(166, 438);
            this.lblResId.Name = "lblResId";
            this.lblResId.Size = new System.Drawing.Size(104, 23);
            this.lblResId.TabIndex = 135;
            this.lblResId.Text = "RES/00002";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.txtResiStatus);
            this.panel7.Controls.Add(this.txtNoofBath);
            this.panel7.Controls.Add(this.txtBlockNa);
            this.panel7.Controls.Add(this.txtResiNa);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.txtNoofRooms);
            this.panel7.Controls.Add(this.txtRentPri);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.txtPurPrice);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Location = new System.Drawing.Point(99, 507);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(690, 219);
            this.panel7.TabIndex = 137;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(33, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 19);
            this.label9.TabIndex = 134;
            this.label9.Text = "Resident Name :-";
            // 
            // txtResiStatus
            // 
            this.txtResiStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResiStatus.Location = new System.Drawing.Point(507, 149);
            this.txtResiStatus.Multiline = true;
            this.txtResiStatus.Name = "txtResiStatus";
            this.txtResiStatus.ReadOnly = true;
            this.txtResiStatus.Size = new System.Drawing.Size(149, 28);
            this.txtResiStatus.TabIndex = 126;
            this.txtResiStatus.Click += new System.EventHandler(this.txtResiStatus_Click);
            this.txtResiStatus.TextChanged += new System.EventHandler(this.txtResiStatus_TextChanged);
            // 
            // txtNoofBath
            // 
            this.txtNoofBath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoofBath.Location = new System.Drawing.Point(351, 149);
            this.txtNoofBath.Multiline = true;
            this.txtNoofBath.Name = "txtNoofBath";
            this.txtNoofBath.Size = new System.Drawing.Size(137, 28);
            this.txtNoofBath.TabIndex = 126;
            // 
            // txtBlockNa
            // 
            this.txtBlockNa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlockNa.Location = new System.Drawing.Point(293, 74);
            this.txtBlockNa.Multiline = true;
            this.txtBlockNa.Name = "txtBlockNa";
            this.txtBlockNa.Size = new System.Drawing.Size(179, 28);
            this.txtBlockNa.TabIndex = 126;
            // 
            // txtResiNa
            // 
            this.txtResiNa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResiNa.Location = new System.Drawing.Point(37, 74);
            this.txtResiNa.Multiline = true;
            this.txtResiNa.Name = "txtResiNa";
            this.txtResiNa.Size = new System.Drawing.Size(227, 28);
            this.txtResiNa.TabIndex = 126;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(347, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 19);
            this.label10.TabIndex = 131;
            this.label10.Text = "No of Bath rooms :-";
            // 
            // txtNoofRooms
            // 
            this.txtNoofRooms.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoofRooms.Location = new System.Drawing.Point(221, 149);
            this.txtNoofRooms.Multiline = true;
            this.txtNoofRooms.Name = "txtNoofRooms";
            this.txtNoofRooms.Size = new System.Drawing.Size(107, 28);
            this.txtNoofRooms.TabIndex = 126;
            // 
            // txtRentPri
            // 
            this.txtRentPri.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentPri.Location = new System.Drawing.Point(39, 149);
            this.txtRentPri.Multiline = true;
            this.txtRentPri.Name = "txtRentPri";
            this.txtRentPri.Size = new System.Drawing.Size(159, 28);
            this.txtRentPri.TabIndex = 129;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(503, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 19);
            this.label8.TabIndex = 132;
            this.label8.Text = "Resident Status :-";
            // 
            // txtPurPrice
            // 
            this.txtPurPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurPrice.Location = new System.Drawing.Point(497, 74);
            this.txtPurPrice.Multiline = true;
            this.txtPurPrice.Name = "txtPurPrice";
            this.txtPurPrice.Size = new System.Drawing.Size(159, 28);
            this.txtPurPrice.TabIndex = 129;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(35, 118);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 19);
            this.label18.TabIndex = 130;
            this.label18.Text = "Rent Price :-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(289, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 19);
            this.label15.TabIndex = 132;
            this.label15.Text = "Resident Block :-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(493, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 19);
            this.label16.TabIndex = 130;
            this.label16.Text = "Purchase Price :-";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(688, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(2, 215);
            this.panel8.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(2, 215);
            this.panel9.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(217, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 19);
            this.label11.TabIndex = 132;
            this.label11.Text = "No of Rooms :-";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 217);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(690, 2);
            this.panel10.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(690, 2);
            this.panel11.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(126, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 22);
            this.label6.TabIndex = 136;
            this.label6.Text = "Resident Unit Details";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.AutoScroll = true;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.panel7);
            this.bunifuGradientPanel1.Controls.Add(this.lblResId);
            this.bunifuGradientPanel1.Controls.Add(this.lblApaNo);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Controls.Add(this.btnDelete);
            this.bunifuGradientPanel1.Controls.Add(this.btnCancel);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.btnCreateAcc);
            this.bunifuGradientPanel1.Controls.Add(this.btnUpdate);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Pink;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightGray;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SlateGray;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 68);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(898, 556);
            this.bunifuGradientPanel1.TabIndex = 36;
            // 
            // frmAddResident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 624);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmAddResident";
            this.Text = "frmAddResident";
            this.Load += new System.EventHandler(this.frmAddResident_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchdetails;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cmbApartNa;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbApartType;
        private System.Windows.Forms.TextBox txtApartLocation;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtApartmentID;
        private Bunifu.Framework.UI.BunifuFlatButton btnPay;
        private System.Windows.Forms.TextBox txtNoLevels;
        private System.Windows.Forms.TextBox txtNoofUnits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAvailUnits;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblApaNo;
        public System.Windows.Forms.Label lblResId;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNoofBath;
        private System.Windows.Forms.TextBox txtBlockNa;
        private System.Windows.Forms.TextBox txtResiNa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNoofRooms;
        private System.Windows.Forms.TextBox txtRentPri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPurPrice;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.TextBox txtResiStatus;
    }
}