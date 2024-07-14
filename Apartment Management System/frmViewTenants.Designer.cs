namespace Apartment_Management_System
{
    partial class frmViewTenants
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearchdetails = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.bunViewTenantDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tenant_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenant_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenant_Fn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenant_Ln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenant_nic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenant_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenant_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_unitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewTenantDetails)).BeginInit();
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
            this.panel2.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(26, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(302, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "View Tenant Details";
            // 
            // txtSearchdetails
            // 
            this.txtSearchdetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchdetails.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchdetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchdetails.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearchdetails.HintText = "Enter Tenant ID/ NIC";
            this.txtSearchdetails.isPassword = false;
            this.txtSearchdetails.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearchdetails.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineThickness = 4;
            this.txtSearchdetails.Location = new System.Drawing.Point(32, 119);
            this.txtSearchdetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchdetails.Name = "txtSearchdetails";
            this.txtSearchdetails.Size = new System.Drawing.Size(245, 44);
            this.txtSearchdetails.TabIndex = 144;
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
            this.button1.TabIndex = 145;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bunViewTenantDetails
            // 
            this.bunViewTenantDetails.AllowUserToAddRows = false;
            this.bunViewTenantDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.bunViewTenantDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunViewTenantDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunViewTenantDetails.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunViewTenantDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunViewTenantDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunViewTenantDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bunViewTenantDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunViewTenantDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenant_Id,
            this.tenant_Title,
            this.tenant_Fn,
            this.tenant_Ln,
            this.tenant_nic,
            this.tenant_contact,
            this.tenant_email,
            this.res_unitID});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunViewTenantDetails.DefaultCellStyle = dataGridViewCellStyle6;
            this.bunViewTenantDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunViewTenantDetails.DoubleBuffered = true;
            this.bunViewTenantDetails.EnableHeadersVisualStyles = false;
            this.bunViewTenantDetails.HeaderBgColor = System.Drawing.SystemColors.HotTrack;
            this.bunViewTenantDetails.HeaderForeColor = System.Drawing.Color.White;
            this.bunViewTenantDetails.Location = new System.Drawing.Point(0, 199);
            this.bunViewTenantDetails.Name = "bunViewTenantDetails";
            this.bunViewTenantDetails.ReadOnly = true;
            this.bunViewTenantDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunViewTenantDetails.Size = new System.Drawing.Size(898, 425);
            this.bunViewTenantDetails.TabIndex = 146;
            // 
            // tenant_Id
            // 
            this.tenant_Id.DataPropertyName = "tenant_Id";
            this.tenant_Id.HeaderText = "Owner ID";
            this.tenant_Id.Name = "tenant_Id";
            this.tenant_Id.ReadOnly = true;
            // 
            // tenant_Title
            // 
            this.tenant_Title.DataPropertyName = "tenant_Title";
            this.tenant_Title.HeaderText = "Title";
            this.tenant_Title.Name = "tenant_Title";
            this.tenant_Title.ReadOnly = true;
            // 
            // tenant_Fn
            // 
            this.tenant_Fn.DataPropertyName = "tenant_Fn";
            this.tenant_Fn.HeaderText = "First Name";
            this.tenant_Fn.Name = "tenant_Fn";
            this.tenant_Fn.ReadOnly = true;
            // 
            // tenant_Ln
            // 
            this.tenant_Ln.DataPropertyName = "tenant_Ln";
            this.tenant_Ln.HeaderText = "Last Name";
            this.tenant_Ln.Name = "tenant_Ln";
            this.tenant_Ln.ReadOnly = true;
            // 
            // tenant_nic
            // 
            this.tenant_nic.DataPropertyName = "tenant_nic";
            this.tenant_nic.HeaderText = "NIC No";
            this.tenant_nic.Name = "tenant_nic";
            this.tenant_nic.ReadOnly = true;
            // 
            // tenant_contact
            // 
            this.tenant_contact.DataPropertyName = "tenant_contact";
            this.tenant_contact.HeaderText = "Contact No";
            this.tenant_contact.Name = "tenant_contact";
            this.tenant_contact.ReadOnly = true;
            // 
            // tenant_email
            // 
            this.tenant_email.DataPropertyName = "tenant_email";
            this.tenant_email.HeaderText = "Email";
            this.tenant_email.Name = "tenant_email";
            this.tenant_email.ReadOnly = true;
            // 
            // res_unitID
            // 
            this.res_unitID.DataPropertyName = "res_unitID";
            this.res_unitID.HeaderText = "Resident ID";
            this.res_unitID.Name = "res_unitID";
            this.res_unitID.ReadOnly = true;
            // 
            // frmViewTenants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 624);
            this.Controls.Add(this.bunViewTenantDetails);
            this.Controls.Add(this.txtSearchdetails);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Name = "frmViewTenants";
            this.Text = "frmViewTenants";
            this.Load += new System.EventHandler(this.frmViewTenants_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewTenantDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchdetails;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunViewTenantDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenant_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenant_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenant_Fn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenant_Ln;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenant_nic;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenant_contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenant_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_unitID;
    }
}