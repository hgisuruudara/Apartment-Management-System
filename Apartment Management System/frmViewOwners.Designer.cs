namespace Apartment_Management_System
{
    partial class frmViewOwners
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
            this.bunViewOwnerDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.owner_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner_Fn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner_Ln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner_nic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_unitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewOwnerDetails)).BeginInit();
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
            this.label12.Size = new System.Drawing.Size(293, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "View Owner Details";
            // 
            // txtSearchdetails
            // 
            this.txtSearchdetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchdetails.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchdetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchdetails.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearchdetails.HintText = "Enter Owner ID/ NIC";
            this.txtSearchdetails.isPassword = false;
            this.txtSearchdetails.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearchdetails.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineThickness = 4;
            this.txtSearchdetails.Location = new System.Drawing.Point(32, 114);
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
            this.button1.Location = new System.Drawing.Point(284, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 73);
            this.button1.TabIndex = 145;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bunViewOwnerDetails
            // 
            this.bunViewOwnerDetails.AllowUserToAddRows = false;
            this.bunViewOwnerDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.bunViewOwnerDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunViewOwnerDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunViewOwnerDetails.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunViewOwnerDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunViewOwnerDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunViewOwnerDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bunViewOwnerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunViewOwnerDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.owner_Id,
            this.owner_Title,
            this.owner_Fn,
            this.owner_Ln,
            this.owner_nic,
            this.owner_contact,
            this.owner_email,
            this.res_unitID});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunViewOwnerDetails.DefaultCellStyle = dataGridViewCellStyle6;
            this.bunViewOwnerDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunViewOwnerDetails.DoubleBuffered = true;
            this.bunViewOwnerDetails.EnableHeadersVisualStyles = false;
            this.bunViewOwnerDetails.HeaderBgColor = System.Drawing.SystemColors.HotTrack;
            this.bunViewOwnerDetails.HeaderForeColor = System.Drawing.Color.White;
            this.bunViewOwnerDetails.Location = new System.Drawing.Point(0, 199);
            this.bunViewOwnerDetails.Name = "bunViewOwnerDetails";
            this.bunViewOwnerDetails.ReadOnly = true;
            this.bunViewOwnerDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunViewOwnerDetails.Size = new System.Drawing.Size(898, 425);
            this.bunViewOwnerDetails.TabIndex = 143;
            // 
            // owner_Id
            // 
            this.owner_Id.DataPropertyName = "owner_Id";
            this.owner_Id.HeaderText = "Owner ID";
            this.owner_Id.Name = "owner_Id";
            this.owner_Id.ReadOnly = true;
            // 
            // owner_Title
            // 
            this.owner_Title.DataPropertyName = "owner_Title";
            this.owner_Title.HeaderText = "Title";
            this.owner_Title.Name = "owner_Title";
            this.owner_Title.ReadOnly = true;
            // 
            // owner_Fn
            // 
            this.owner_Fn.DataPropertyName = "owner_Fn";
            this.owner_Fn.HeaderText = "First Name";
            this.owner_Fn.Name = "owner_Fn";
            this.owner_Fn.ReadOnly = true;
            // 
            // owner_Ln
            // 
            this.owner_Ln.DataPropertyName = "owner_Ln";
            this.owner_Ln.HeaderText = "Last Name";
            this.owner_Ln.Name = "owner_Ln";
            this.owner_Ln.ReadOnly = true;
            // 
            // owner_nic
            // 
            this.owner_nic.DataPropertyName = "owner_nic";
            this.owner_nic.HeaderText = "NIC No";
            this.owner_nic.Name = "owner_nic";
            this.owner_nic.ReadOnly = true;
            // 
            // owner_contact
            // 
            this.owner_contact.DataPropertyName = "owner_contact";
            this.owner_contact.HeaderText = "Contact No";
            this.owner_contact.Name = "owner_contact";
            this.owner_contact.ReadOnly = true;
            // 
            // owner_email
            // 
            this.owner_email.DataPropertyName = "owner_email";
            this.owner_email.HeaderText = "Email";
            this.owner_email.Name = "owner_email";
            this.owner_email.ReadOnly = true;
            // 
            // res_unitID
            // 
            this.res_unitID.DataPropertyName = "res_unitID";
            this.res_unitID.HeaderText = "Resident ID";
            this.res_unitID.Name = "res_unitID";
            this.res_unitID.ReadOnly = true;
            // 
            // frmViewOwners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 624);
            this.Controls.Add(this.txtSearchdetails);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunViewOwnerDetails);
            this.Controls.Add(this.panel2);
            this.Name = "frmViewOwners";
            this.Text = "frmViewOwners";
            this.Load += new System.EventHandler(this.frmViewOwners_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewOwnerDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchdetails;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunViewOwnerDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_Fn;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_Ln;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_nic;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_unitID;
    }
}