namespace Apartment_Management_System
{
    partial class frmViewAccountDetails
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearchdetails = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.bunViewAccountDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.emp_regDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_fn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_ln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_nic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_address_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_address_street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_address_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_address_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewAccountDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 68);
            this.panel2.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(26, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(341, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "View Employee  Details";
            // 
            // txtSearchdetails
            // 
            this.txtSearchdetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchdetails.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchdetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchdetails.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearchdetails.HintText = "Enter EMP ID/ NIC";
            this.txtSearchdetails.isPassword = false;
            this.txtSearchdetails.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearchdetails.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineThickness = 4;
            this.txtSearchdetails.Location = new System.Drawing.Point(32, 119);
            this.txtSearchdetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchdetails.Name = "txtSearchdetails";
            this.txtSearchdetails.Size = new System.Drawing.Size(245, 44);
            this.txtSearchdetails.TabIndex = 147;
            this.txtSearchdetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchdetails.OnValueChanged += new System.EventHandler(this.txtSearchdetails_OnValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Apartment_Management_System.Properties.Resources.search3;
            this.button1.Location = new System.Drawing.Point(284, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 73);
            this.button1.TabIndex = 148;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bunViewAccountDetails
            // 
            this.bunViewAccountDetails.AllowUserToAddRows = false;
            this.bunViewAccountDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunViewAccountDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunViewAccountDetails.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunViewAccountDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunViewAccountDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunViewAccountDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunViewAccountDetails.ColumnHeadersHeight = 40;
            this.bunViewAccountDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emp_regDate,
            this.emp_id,
            this.emp_title,
            this.emp_fn,
            this.emp_ln,
            this.emp_nic,
            this.emp_address_no,
            this.emp_address_street,
            this.emp_address_city,
            this.emp_address_state,
            this.emp_contact,
            this.emp_email,
            this.emp_type,
            this.emp_status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunViewAccountDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunViewAccountDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunViewAccountDetails.DoubleBuffered = true;
            this.bunViewAccountDetails.EnableHeadersVisualStyles = false;
            this.bunViewAccountDetails.HeaderBgColor = System.Drawing.SystemColors.HotTrack;
            this.bunViewAccountDetails.HeaderForeColor = System.Drawing.Color.White;
            this.bunViewAccountDetails.Location = new System.Drawing.Point(0, 199);
            this.bunViewAccountDetails.Name = "bunViewAccountDetails";
            this.bunViewAccountDetails.ReadOnly = true;
            this.bunViewAccountDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunViewAccountDetails.Size = new System.Drawing.Size(898, 425);
            this.bunViewAccountDetails.TabIndex = 149;
            // 
            // emp_regDate
            // 
            this.emp_regDate.DataPropertyName = "emp_regDate";
            this.emp_regDate.FillWeight = 276.7504F;
            this.emp_regDate.HeaderText = "Reg Date";
            this.emp_regDate.Name = "emp_regDate";
            this.emp_regDate.ReadOnly = true;
            // 
            // emp_id
            // 
            this.emp_id.DataPropertyName = "emp_id";
            this.emp_id.FillWeight = 540.7714F;
            this.emp_id.HeaderText = "Employee ID";
            this.emp_id.Name = "emp_id";
            this.emp_id.ReadOnly = true;
            this.emp_id.Width = 120;
            // 
            // emp_title
            // 
            this.emp_title.DataPropertyName = "emp_title";
            this.emp_title.FillWeight = 355.33F;
            this.emp_title.HeaderText = "Title";
            this.emp_title.Name = "emp_title";
            this.emp_title.ReadOnly = true;
            this.emp_title.Width = 50;
            // 
            // emp_fn
            // 
            this.emp_fn.DataPropertyName = "emp_fn";
            this.emp_fn.FillWeight = 20.64984F;
            this.emp_fn.HeaderText = "First Name";
            this.emp_fn.Name = "emp_fn";
            this.emp_fn.ReadOnly = true;
            this.emp_fn.Width = 120;
            // 
            // emp_ln
            // 
            this.emp_ln.DataPropertyName = "emp_ln";
            this.emp_ln.FillWeight = 20.64984F;
            this.emp_ln.HeaderText = "Last Name";
            this.emp_ln.Name = "emp_ln";
            this.emp_ln.ReadOnly = true;
            this.emp_ln.Width = 120;
            // 
            // emp_nic
            // 
            this.emp_nic.DataPropertyName = "emp_nic";
            this.emp_nic.FillWeight = 20.64984F;
            this.emp_nic.HeaderText = "NIC";
            this.emp_nic.Name = "emp_nic";
            this.emp_nic.ReadOnly = true;
            // 
            // emp_address_no
            // 
            this.emp_address_no.DataPropertyName = "emp_address_no";
            this.emp_address_no.FillWeight = 20.64984F;
            this.emp_address_no.HeaderText = "House No";
            this.emp_address_no.Name = "emp_address_no";
            this.emp_address_no.ReadOnly = true;
            // 
            // emp_address_street
            // 
            this.emp_address_street.DataPropertyName = "emp_address_street";
            this.emp_address_street.FillWeight = 20.64984F;
            this.emp_address_street.HeaderText = "Street";
            this.emp_address_street.Name = "emp_address_street";
            this.emp_address_street.ReadOnly = true;
            this.emp_address_street.Width = 150;
            // 
            // emp_address_city
            // 
            this.emp_address_city.DataPropertyName = "emp_address_city";
            this.emp_address_city.FillWeight = 20.64984F;
            this.emp_address_city.HeaderText = "City";
            this.emp_address_city.Name = "emp_address_city";
            this.emp_address_city.ReadOnly = true;
            // 
            // emp_address_state
            // 
            this.emp_address_state.DataPropertyName = "emp_address_state";
            this.emp_address_state.FillWeight = 20.64984F;
            this.emp_address_state.HeaderText = "State";
            this.emp_address_state.Name = "emp_address_state";
            this.emp_address_state.ReadOnly = true;
            // 
            // emp_contact
            // 
            this.emp_contact.DataPropertyName = "emp_contact";
            this.emp_contact.FillWeight = 20.64984F;
            this.emp_contact.HeaderText = "Contact";
            this.emp_contact.Name = "emp_contact";
            this.emp_contact.ReadOnly = true;
            // 
            // emp_email
            // 
            this.emp_email.DataPropertyName = "emp_email";
            this.emp_email.FillWeight = 20.64984F;
            this.emp_email.HeaderText = "Email";
            this.emp_email.Name = "emp_email";
            this.emp_email.ReadOnly = true;
            this.emp_email.Width = 150;
            // 
            // emp_type
            // 
            this.emp_type.DataPropertyName = "emp_type";
            this.emp_type.FillWeight = 20.64984F;
            this.emp_type.HeaderText = "Type";
            this.emp_type.Name = "emp_type";
            this.emp_type.ReadOnly = true;
            this.emp_type.Width = 75;
            // 
            // emp_status
            // 
            this.emp_status.DataPropertyName = "emp_status";
            this.emp_status.FillWeight = 20.64984F;
            this.emp_status.HeaderText = "Status";
            this.emp_status.Name = "emp_status";
            this.emp_status.ReadOnly = true;
            this.emp_status.Width = 75;
            // 
            // frmViewAccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 624);
            this.Controls.Add(this.bunViewAccountDetails);
            this.Controls.Add(this.txtSearchdetails);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Name = "frmViewAccountDetails";
            this.Text = "frmViewAccountDetails";
            this.Load += new System.EventHandler(this.frmViewAccountDetails_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewAccountDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchdetails;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunViewAccountDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_regDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_fn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_ln;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_nic;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_address_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_address_street;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_address_city;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_address_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_status;
    }
}