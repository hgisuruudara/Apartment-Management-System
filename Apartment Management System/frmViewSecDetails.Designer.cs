namespace Apartment_Management_System
{
    partial class frmViewSecDetails
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
            this.bunViewSecDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtSearchdetails = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.secguard_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secguard_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secguard_Fn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secguard_Ln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secguard_nic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secguard_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secguard_company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secguard_companyTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dutyon_DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dutyontime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dutyoff_DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dutyofftime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apart_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewSecDetails)).BeginInit();
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
            this.label12.Size = new System.Drawing.Size(424, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "View Security Guard Details";
            // 
            // bunViewSecDetails
            // 
            this.bunViewSecDetails.AllowUserToAddRows = false;
            this.bunViewSecDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunViewSecDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunViewSecDetails.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunViewSecDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunViewSecDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunViewSecDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunViewSecDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunViewSecDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.secguard_ID,
            this.secguard_Title,
            this.secguard_Fn,
            this.secguard_Ln,
            this.secguard_nic,
            this.secguard_contact,
            this.secguard_company,
            this.secguard_companyTel,
            this.dutyon_DateTime,
            this.dutyontime,
            this.dutyoff_DateTime,
            this.dutyofftime,
            this.apart_id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunViewSecDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunViewSecDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunViewSecDetails.DoubleBuffered = true;
            this.bunViewSecDetails.EnableHeadersVisualStyles = false;
            this.bunViewSecDetails.HeaderBgColor = System.Drawing.SystemColors.HotTrack;
            this.bunViewSecDetails.HeaderForeColor = System.Drawing.Color.White;
            this.bunViewSecDetails.Location = new System.Drawing.Point(0, 199);
            this.bunViewSecDetails.Name = "bunViewSecDetails";
            this.bunViewSecDetails.ReadOnly = true;
            this.bunViewSecDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunViewSecDetails.Size = new System.Drawing.Size(898, 425);
            this.bunViewSecDetails.TabIndex = 155;
            // 
            // txtSearchdetails
            // 
            this.txtSearchdetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchdetails.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchdetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchdetails.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearchdetails.HintText = "Enter Apartment ID / SEC ID";
            this.txtSearchdetails.isPassword = false;
            this.txtSearchdetails.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearchdetails.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineThickness = 4;
            this.txtSearchdetails.Location = new System.Drawing.Point(32, 120);
            this.txtSearchdetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchdetails.Name = "txtSearchdetails";
            this.txtSearchdetails.Size = new System.Drawing.Size(268, 44);
            this.txtSearchdetails.TabIndex = 153;
            this.txtSearchdetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchdetails.OnValueChanged += new System.EventHandler(this.txtSearchdetails_OnValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Apartment_Management_System.Properties.Resources.search3;
            this.button1.Location = new System.Drawing.Point(307, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 73);
            this.button1.TabIndex = 154;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // secguard_ID
            // 
            this.secguard_ID.DataPropertyName = "secguard_ID";
            this.secguard_ID.HeaderText = "Security ID";
            this.secguard_ID.Name = "secguard_ID";
            this.secguard_ID.ReadOnly = true;
            this.secguard_ID.Width = 150;
            // 
            // secguard_Title
            // 
            this.secguard_Title.DataPropertyName = "secguard_Title";
            this.secguard_Title.HeaderText = "Title";
            this.secguard_Title.Name = "secguard_Title";
            this.secguard_Title.ReadOnly = true;
            this.secguard_Title.Width = 45;
            // 
            // secguard_Fn
            // 
            this.secguard_Fn.DataPropertyName = "secguard_Fn";
            this.secguard_Fn.HeaderText = "First Name";
            this.secguard_Fn.Name = "secguard_Fn";
            this.secguard_Fn.ReadOnly = true;
            this.secguard_Fn.Width = 150;
            // 
            // secguard_Ln
            // 
            this.secguard_Ln.DataPropertyName = "secguard_Ln";
            this.secguard_Ln.HeaderText = "Last Name";
            this.secguard_Ln.Name = "secguard_Ln";
            this.secguard_Ln.ReadOnly = true;
            this.secguard_Ln.Width = 150;
            // 
            // secguard_nic
            // 
            this.secguard_nic.DataPropertyName = "secguard_nic";
            this.secguard_nic.HeaderText = "NIC No";
            this.secguard_nic.Name = "secguard_nic";
            this.secguard_nic.ReadOnly = true;
            // 
            // secguard_contact
            // 
            this.secguard_contact.DataPropertyName = "secguard_contact";
            this.secguard_contact.HeaderText = "Contact No";
            this.secguard_contact.Name = "secguard_contact";
            this.secguard_contact.ReadOnly = true;
            // 
            // secguard_company
            // 
            this.secguard_company.DataPropertyName = "secguard_company";
            this.secguard_company.HeaderText = "Security Company";
            this.secguard_company.Name = "secguard_company";
            this.secguard_company.ReadOnly = true;
            // 
            // secguard_companyTel
            // 
            this.secguard_companyTel.DataPropertyName = "secguard_companyTel";
            this.secguard_companyTel.HeaderText = "Company Tel";
            this.secguard_companyTel.Name = "secguard_companyTel";
            this.secguard_companyTel.ReadOnly = true;
            // 
            // dutyon_DateTime
            // 
            this.dutyon_DateTime.DataPropertyName = "dutyon_DateTime";
            this.dutyon_DateTime.HeaderText = "Duty On Date";
            this.dutyon_DateTime.Name = "dutyon_DateTime";
            this.dutyon_DateTime.ReadOnly = true;
            // 
            // dutyontime
            // 
            this.dutyontime.DataPropertyName = "dutyontime";
            this.dutyontime.HeaderText = "Duty On Time";
            this.dutyontime.Name = "dutyontime";
            this.dutyontime.ReadOnly = true;
            // 
            // dutyoff_DateTime
            // 
            this.dutyoff_DateTime.DataPropertyName = "dutyoff_DateTime";
            this.dutyoff_DateTime.HeaderText = "Duty Off Date";
            this.dutyoff_DateTime.Name = "dutyoff_DateTime";
            this.dutyoff_DateTime.ReadOnly = true;
            // 
            // dutyofftime
            // 
            this.dutyofftime.DataPropertyName = "dutyofftime";
            this.dutyofftime.HeaderText = "Duty Off Time";
            this.dutyofftime.Name = "dutyofftime";
            this.dutyofftime.ReadOnly = true;
            // 
            // apart_id
            // 
            this.apart_id.DataPropertyName = "apart_id";
            this.apart_id.HeaderText = "Apartment ID";
            this.apart_id.Name = "apart_id";
            this.apart_id.ReadOnly = true;
            this.apart_id.Width = 75;
            // 
            // frmViewSecDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 624);
            this.Controls.Add(this.bunViewSecDetails);
            this.Controls.Add(this.txtSearchdetails);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Name = "frmViewSecDetails";
            this.Text = "frmViewSecDetails";
            this.Load += new System.EventHandler(this.frmViewSecDetails_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewSecDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunViewSecDetails;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchdetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn secguard_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn secguard_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn secguard_Fn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secguard_Ln;
        private System.Windows.Forms.DataGridViewTextBoxColumn secguard_nic;
        private System.Windows.Forms.DataGridViewTextBoxColumn secguard_contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn secguard_company;
        private System.Windows.Forms.DataGridViewTextBoxColumn secguard_companyTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dutyon_DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dutyontime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dutyoff_DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dutyofftime;
        private System.Windows.Forms.DataGridViewTextBoxColumn apart_id;
    }
}