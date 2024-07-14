namespace Apartment_Management_System
{
    partial class frmViewPayHistory
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
            this.bunViewPayDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtSearchdetails = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.inv_dateandtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cus_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cus_Fn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cus_Ln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cus_nic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cus_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cus_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay_method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paying_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay_balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerID_TenantID_MaintenanceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_unitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apart_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewPayDetails)).BeginInit();
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
            this.panel2.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(26, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(329, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "View Payment History";
            // 
            // bunViewPayDetails
            // 
            this.bunViewPayDetails.AllowUserToAddRows = false;
            this.bunViewPayDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunViewPayDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunViewPayDetails.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunViewPayDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunViewPayDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunViewPayDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunViewPayDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunViewPayDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inv_dateandtime,
            this.invoice_ID,
            this.cus_title,
            this.cus_Fn,
            this.cus_Ln,
            this.cus_nic,
            this.cus_contact,
            this.cus_email,
            this.pay_category,
            this.service_type,
            this.pay_method,
            this.total_amount,
            this.paying_amount,
            this.pay_balance,
            this.OwnerID_TenantID_MaintenanceID,
            this.res_unitID,
            this.apart_id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunViewPayDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunViewPayDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunViewPayDetails.DoubleBuffered = true;
            this.bunViewPayDetails.EnableHeadersVisualStyles = false;
            this.bunViewPayDetails.HeaderBgColor = System.Drawing.SystemColors.HotTrack;
            this.bunViewPayDetails.HeaderForeColor = System.Drawing.Color.White;
            this.bunViewPayDetails.Location = new System.Drawing.Point(0, 205);
            this.bunViewPayDetails.Name = "bunViewPayDetails";
            this.bunViewPayDetails.ReadOnly = true;
            this.bunViewPayDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunViewPayDetails.Size = new System.Drawing.Size(898, 419);
            this.bunViewPayDetails.TabIndex = 153;
            // 
            // txtSearchdetails
            // 
            this.txtSearchdetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchdetails.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchdetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchdetails.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearchdetails.HintText = "Enter Payment ID / Type /  RES ID ";
            this.txtSearchdetails.isPassword = false;
            this.txtSearchdetails.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearchdetails.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineThickness = 4;
            this.txtSearchdetails.Location = new System.Drawing.Point(44, 131);
            this.txtSearchdetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchdetails.Name = "txtSearchdetails";
            this.txtSearchdetails.Size = new System.Drawing.Size(311, 44);
            this.txtSearchdetails.TabIndex = 154;
            this.txtSearchdetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchdetails.OnValueChanged += new System.EventHandler(this.txtSearchdetails_OnValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Apartment_Management_System.Properties.Resources.search3;
            this.button1.Location = new System.Drawing.Point(362, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 73);
            this.button1.TabIndex = 155;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // inv_dateandtime
            // 
            this.inv_dateandtime.DataPropertyName = "inv_dateandtime";
            this.inv_dateandtime.HeaderText = "Date & Time";
            this.inv_dateandtime.Name = "inv_dateandtime";
            this.inv_dateandtime.ReadOnly = true;
            // 
            // invoice_ID
            // 
            this.invoice_ID.DataPropertyName = "invoice_ID";
            this.invoice_ID.HeaderText = "Invoice ID";
            this.invoice_ID.Name = "invoice_ID";
            this.invoice_ID.ReadOnly = true;
            // 
            // cus_title
            // 
            this.cus_title.DataPropertyName = "cus_title";
            this.cus_title.HeaderText = "Title";
            this.cus_title.Name = "cus_title";
            this.cus_title.ReadOnly = true;
            // 
            // cus_Fn
            // 
            this.cus_Fn.DataPropertyName = "cus_Fn";
            this.cus_Fn.HeaderText = "First Name";
            this.cus_Fn.Name = "cus_Fn";
            this.cus_Fn.ReadOnly = true;
            // 
            // cus_Ln
            // 
            this.cus_Ln.DataPropertyName = "cus_Ln";
            this.cus_Ln.HeaderText = "Last Name";
            this.cus_Ln.Name = "cus_Ln";
            this.cus_Ln.ReadOnly = true;
            // 
            // cus_nic
            // 
            this.cus_nic.DataPropertyName = "cus_nic";
            this.cus_nic.HeaderText = "NIC";
            this.cus_nic.Name = "cus_nic";
            this.cus_nic.ReadOnly = true;
            // 
            // cus_contact
            // 
            this.cus_contact.DataPropertyName = "cus_contact";
            this.cus_contact.HeaderText = "Contact";
            this.cus_contact.Name = "cus_contact";
            this.cus_contact.ReadOnly = true;
            // 
            // cus_email
            // 
            this.cus_email.DataPropertyName = "cus_email";
            this.cus_email.HeaderText = "Email";
            this.cus_email.Name = "cus_email";
            this.cus_email.ReadOnly = true;
            // 
            // pay_category
            // 
            this.pay_category.DataPropertyName = "pay_category";
            this.pay_category.HeaderText = "Payment Category";
            this.pay_category.Name = "pay_category";
            this.pay_category.ReadOnly = true;
            // 
            // service_type
            // 
            this.service_type.DataPropertyName = "service_type";
            this.service_type.HeaderText = "Service Type";
            this.service_type.Name = "service_type";
            this.service_type.ReadOnly = true;
            // 
            // pay_method
            // 
            this.pay_method.DataPropertyName = "pay_method";
            this.pay_method.HeaderText = "Payment Method";
            this.pay_method.Name = "pay_method";
            this.pay_method.ReadOnly = true;
            // 
            // total_amount
            // 
            this.total_amount.DataPropertyName = "total_amount";
            this.total_amount.HeaderText = "Total Amount";
            this.total_amount.Name = "total_amount";
            this.total_amount.ReadOnly = true;
            // 
            // paying_amount
            // 
            this.paying_amount.DataPropertyName = "paying_amount";
            this.paying_amount.HeaderText = "Pay Amount";
            this.paying_amount.Name = "paying_amount";
            this.paying_amount.ReadOnly = true;
            // 
            // pay_balance
            // 
            this.pay_balance.DataPropertyName = "pay_balance";
            this.pay_balance.HeaderText = "Balance to Pay";
            this.pay_balance.Name = "pay_balance";
            this.pay_balance.ReadOnly = true;
            // 
            // OwnerID_TenantID_MaintenanceID
            // 
            this.OwnerID_TenantID_MaintenanceID.DataPropertyName = "OwnerID_TenantID_MaintenanceID";
            this.OwnerID_TenantID_MaintenanceID.HeaderText = "Owner,Tenant, Maintain ID";
            this.OwnerID_TenantID_MaintenanceID.Name = "OwnerID_TenantID_MaintenanceID";
            this.OwnerID_TenantID_MaintenanceID.ReadOnly = true;
            // 
            // res_unitID
            // 
            this.res_unitID.DataPropertyName = "res_unitID";
            this.res_unitID.HeaderText = "Resident ID";
            this.res_unitID.Name = "res_unitID";
            this.res_unitID.ReadOnly = true;
            // 
            // apart_id
            // 
            this.apart_id.DataPropertyName = "apart_id";
            this.apart_id.HeaderText = "Apartment ID";
            this.apart_id.Name = "apart_id";
            this.apart_id.ReadOnly = true;
            // 
            // frmViewPayHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 624);
            this.Controls.Add(this.txtSearchdetails);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunViewPayDetails);
            this.Controls.Add(this.panel2);
            this.Name = "frmViewPayHistory";
            this.Text = "frmViewPayHistory";
            this.Load += new System.EventHandler(this.frmViewPayHistory_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewPayDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunViewPayDetails;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchdetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inv_dateandtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_Fn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_Ln;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_nic;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_method;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn paying_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerID_TenantID_MaintenanceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_unitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn apart_id;
    }
}