namespace Apartment_Management_System
{
    partial class frmViewResidentDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunViewResDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearchdetails = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.res_unitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_blockLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_noOfRooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_noOfBathRooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_rentAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apart_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewResDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunViewResDetails
            // 
            this.bunViewResDetails.AllowUserToAddRows = false;
            this.bunViewResDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunViewResDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunViewResDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunViewResDetails.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunViewResDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunViewResDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunViewResDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunViewResDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunViewResDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.res_unitID,
            this.res_name,
            this.res_blockLocation,
            this.res_noOfRooms,
            this.res_noOfBathRooms,
            this.res_price,
            this.res_rentAmt,
            this.res_Status,
            this.apart_id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunViewResDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunViewResDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunViewResDetails.DoubleBuffered = true;
            this.bunViewResDetails.EnableHeadersVisualStyles = false;
            this.bunViewResDetails.HeaderBgColor = System.Drawing.SystemColors.HotTrack;
            this.bunViewResDetails.HeaderForeColor = System.Drawing.Color.White;
            this.bunViewResDetails.Location = new System.Drawing.Point(0, 182);
            this.bunViewResDetails.Name = "bunViewResDetails";
            this.bunViewResDetails.ReadOnly = true;
            this.bunViewResDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunViewResDetails.Size = new System.Drawing.Size(898, 442);
            this.bunViewResDetails.TabIndex = 138;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(26, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(372, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "View Residential Details";
            // 
            // txtSearchdetails
            // 
            this.txtSearchdetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchdetails.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchdetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchdetails.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearchdetails.HintText = "Enter Resident ID/Apartment ID";
            this.txtSearchdetails.isPassword = false;
            this.txtSearchdetails.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearchdetails.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineThickness = 4;
            this.txtSearchdetails.Location = new System.Drawing.Point(28, 106);
            this.txtSearchdetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchdetails.Name = "txtSearchdetails";
            this.txtSearchdetails.Size = new System.Drawing.Size(300, 44);
            this.txtSearchdetails.TabIndex = 136;
            this.txtSearchdetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchdetails.OnValueChanged += new System.EventHandler(this.txtSearchdetails_OnValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 68);
            this.panel2.TabIndex = 137;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Apartment_Management_System.Properties.Resources.search3;
            this.button1.Location = new System.Drawing.Point(335, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 73);
            this.button1.TabIndex = 140;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // res_unitID
            // 
            this.res_unitID.DataPropertyName = "res_unitID";
            this.res_unitID.HeaderText = "Resident ID";
            this.res_unitID.Name = "res_unitID";
            this.res_unitID.ReadOnly = true;
            // 
            // res_name
            // 
            this.res_name.DataPropertyName = "res_name";
            this.res_name.HeaderText = "Resident Name";
            this.res_name.Name = "res_name";
            this.res_name.ReadOnly = true;
            // 
            // res_blockLocation
            // 
            this.res_blockLocation.DataPropertyName = "res_blockLocation";
            this.res_blockLocation.HeaderText = "Block";
            this.res_blockLocation.Name = "res_blockLocation";
            this.res_blockLocation.ReadOnly = true;
            // 
            // res_noOfRooms
            // 
            this.res_noOfRooms.DataPropertyName = "res_noOfRooms";
            this.res_noOfRooms.HeaderText = "No of Rooms";
            this.res_noOfRooms.Name = "res_noOfRooms";
            this.res_noOfRooms.ReadOnly = true;
            // 
            // res_noOfBathRooms
            // 
            this.res_noOfBathRooms.DataPropertyName = "res_noOfBathRooms";
            this.res_noOfBathRooms.HeaderText = "No of Bathrooms";
            this.res_noOfBathRooms.Name = "res_noOfBathRooms";
            this.res_noOfBathRooms.ReadOnly = true;
            // 
            // res_price
            // 
            this.res_price.DataPropertyName = "res_price";
            this.res_price.HeaderText = "Purchase Price";
            this.res_price.Name = "res_price";
            this.res_price.ReadOnly = true;
            // 
            // res_rentAmt
            // 
            this.res_rentAmt.DataPropertyName = "res_rentAmt";
            this.res_rentAmt.HeaderText = "Rent Amount";
            this.res_rentAmt.Name = "res_rentAmt";
            this.res_rentAmt.ReadOnly = true;
            // 
            // res_Status
            // 
            this.res_Status.DataPropertyName = "res_Status";
            this.res_Status.HeaderText = "Status";
            this.res_Status.Name = "res_Status";
            this.res_Status.ReadOnly = true;
            // 
            // apart_id
            // 
            this.apart_id.DataPropertyName = "apart_id";
            this.apart_id.HeaderText = "Apartment ID";
            this.apart_id.Name = "apart_id";
            this.apart_id.ReadOnly = true;
            // 
            // frmViewResidentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 624);
            this.Controls.Add(this.bunViewResDetails);
            this.Controls.Add(this.txtSearchdetails);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Name = "frmViewResidentDetail";
            this.Text = "frmViewResidentDetail";
            this.Load += new System.EventHandler(this.frmViewResidentDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunViewResDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunViewResDetails;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchdetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_unitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_blockLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_noOfRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_noOfBathRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_rentAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn apart_id;
    }
}