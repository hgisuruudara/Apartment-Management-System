namespace Apartment_Management_System
{
    partial class frmViewApartmentDetails
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
            this.bunViewApartDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearchdetails = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.apart_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apart_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apart_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apart_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apart_levels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apart_residentialunits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apart_unitAvailaStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewApartDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunViewApartDetails
            // 
            this.bunViewApartDetails.AllowUserToAddRows = false;
            this.bunViewApartDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.bunViewApartDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunViewApartDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunViewApartDetails.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunViewApartDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunViewApartDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunViewApartDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bunViewApartDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunViewApartDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apart_id,
            this.apart_name,
            this.apart_location,
            this.apart_type,
            this.apart_levels,
            this.apart_residentialunits,
            this.apart_unitAvailaStatus});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunViewApartDetails.DefaultCellStyle = dataGridViewCellStyle6;
            this.bunViewApartDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunViewApartDetails.DoubleBuffered = true;
            this.bunViewApartDetails.EnableHeadersVisualStyles = false;
            this.bunViewApartDetails.HeaderBgColor = System.Drawing.SystemColors.HotTrack;
            this.bunViewApartDetails.HeaderForeColor = System.Drawing.Color.White;
            this.bunViewApartDetails.Location = new System.Drawing.Point(0, 199);
            this.bunViewApartDetails.Name = "bunViewApartDetails";
            this.bunViewApartDetails.ReadOnly = true;
            this.bunViewApartDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunViewApartDetails.Size = new System.Drawing.Size(898, 425);
            this.bunViewApartDetails.TabIndex = 132;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(26, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(358, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "View Apartment Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 68);
            this.panel2.TabIndex = 131;
            // 
            // txtSearchdetails
            // 
            this.txtSearchdetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchdetails.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchdetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchdetails.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearchdetails.HintText = "Enter Apartment ID/ Type";
            this.txtSearchdetails.isPassword = false;
            this.txtSearchdetails.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearchdetails.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineThickness = 4;
            this.txtSearchdetails.Location = new System.Drawing.Point(32, 113);
            this.txtSearchdetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchdetails.Name = "txtSearchdetails";
            this.txtSearchdetails.Size = new System.Drawing.Size(245, 44);
            this.txtSearchdetails.TabIndex = 141;
            this.txtSearchdetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchdetails.OnValueChanged += new System.EventHandler(this.txtSearchdetails_OnValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Apartment_Management_System.Properties.Resources.search3;
            this.button1.Location = new System.Drawing.Point(284, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 73);
            this.button1.TabIndex = 142;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // apart_id
            // 
            this.apart_id.DataPropertyName = "apart_id";
            this.apart_id.HeaderText = "Apartment ID";
            this.apart_id.Name = "apart_id";
            this.apart_id.ReadOnly = true;
            // 
            // apart_name
            // 
            this.apart_name.DataPropertyName = "apart_name";
            this.apart_name.HeaderText = "Name";
            this.apart_name.Name = "apart_name";
            this.apart_name.ReadOnly = true;
            // 
            // apart_location
            // 
            this.apart_location.DataPropertyName = "apart_location";
            this.apart_location.HeaderText = "Location";
            this.apart_location.Name = "apart_location";
            this.apart_location.ReadOnly = true;
            // 
            // apart_type
            // 
            this.apart_type.DataPropertyName = "apart_type";
            this.apart_type.HeaderText = "Type";
            this.apart_type.Name = "apart_type";
            this.apart_type.ReadOnly = true;
            // 
            // apart_levels
            // 
            this.apart_levels.DataPropertyName = "apart_levels";
            this.apart_levels.HeaderText = "No of Levels";
            this.apart_levels.Name = "apart_levels";
            this.apart_levels.ReadOnly = true;
            // 
            // apart_residentialunits
            // 
            this.apart_residentialunits.DataPropertyName = "apart_residentialunits";
            this.apart_residentialunits.HeaderText = "No of Residential Units";
            this.apart_residentialunits.Name = "apart_residentialunits";
            this.apart_residentialunits.ReadOnly = true;
            // 
            // apart_unitAvailaStatus
            // 
            this.apart_unitAvailaStatus.DataPropertyName = "apart_unitAvailaStatus";
            this.apart_unitAvailaStatus.HeaderText = "Available Units";
            this.apart_unitAvailaStatus.Name = "apart_unitAvailaStatus";
            this.apart_unitAvailaStatus.ReadOnly = true;
            // 
            // frmViewApartmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 624);
            this.Controls.Add(this.txtSearchdetails);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunViewApartDetails);
            this.Controls.Add(this.panel2);
            this.Name = "frmViewApartmentDetails";
            this.Text = "frmViewApartmentDetails";
            this.Load += new System.EventHandler(this.frmViewApartmentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunViewApartDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunViewApartDetails;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchdetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apart_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn apart_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn apart_location;
        private System.Windows.Forms.DataGridViewTextBoxColumn apart_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn apart_levels;
        private System.Windows.Forms.DataGridViewTextBoxColumn apart_residentialunits;
        private System.Windows.Forms.DataGridViewTextBoxColumn apart_unitAvailaStatus;

    }
}