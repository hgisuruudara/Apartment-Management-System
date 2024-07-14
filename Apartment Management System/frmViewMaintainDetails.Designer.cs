namespace Apartment_Management_System
{
    partial class frmViewMaintainDetails
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
            this.bunViewMaintainDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtSearchdetails = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.mantain_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mantain_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mantain_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problem_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approx_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mantain_Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_unitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner_Id_tenant_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewMaintainDetails)).BeginInit();
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
            this.label12.Location = new System.Drawing.Point(21, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(539, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "View Monthly Maintenance Requests";
            // 
            // bunViewMaintainDetails
            // 
            this.bunViewMaintainDetails.AllowUserToAddRows = false;
            this.bunViewMaintainDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunViewMaintainDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunViewMaintainDetails.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunViewMaintainDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunViewMaintainDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunViewMaintainDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunViewMaintainDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunViewMaintainDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mantain_ID,
            this.request_datetime,
            this.mantain_type,
            this.mantain_area,
            this.problem_desc,
            this.approx_cost,
            this.mantain_Month,
            this.res_unitID,
            this.owner_Id_tenant_Id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunViewMaintainDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunViewMaintainDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunViewMaintainDetails.DoubleBuffered = true;
            this.bunViewMaintainDetails.EnableHeadersVisualStyles = false;
            this.bunViewMaintainDetails.HeaderBgColor = System.Drawing.SystemColors.HotTrack;
            this.bunViewMaintainDetails.HeaderForeColor = System.Drawing.Color.White;
            this.bunViewMaintainDetails.Location = new System.Drawing.Point(0, 199);
            this.bunViewMaintainDetails.Name = "bunViewMaintainDetails";
            this.bunViewMaintainDetails.ReadOnly = true;
            this.bunViewMaintainDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunViewMaintainDetails.Size = new System.Drawing.Size(898, 425);
            this.bunViewMaintainDetails.TabIndex = 149;
            // 
            // txtSearchdetails
            // 
            this.txtSearchdetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchdetails.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchdetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchdetails.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearchdetails.HintText = "Enter Request ID / RES ID";
            this.txtSearchdetails.isPassword = false;
            this.txtSearchdetails.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearchdetails.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineThickness = 4;
            this.txtSearchdetails.Location = new System.Drawing.Point(27, 117);
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
            this.button1.Location = new System.Drawing.Point(279, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 73);
            this.button1.TabIndex = 148;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // mantain_ID
            // 
            this.mantain_ID.DataPropertyName = "mantain_ID";
            this.mantain_ID.HeaderText = "Maintain ID";
            this.mantain_ID.Name = "mantain_ID";
            this.mantain_ID.ReadOnly = true;
            this.mantain_ID.Width = 95;
            // 
            // request_datetime
            // 
            this.request_datetime.DataPropertyName = "request_datetime";
            this.request_datetime.HeaderText = "Date & Time";
            this.request_datetime.Name = "request_datetime";
            this.request_datetime.ReadOnly = true;
            this.request_datetime.Width = 95;
            // 
            // mantain_type
            // 
            this.mantain_type.DataPropertyName = "mantain_type";
            this.mantain_type.HeaderText = "Maintain Type";
            this.mantain_type.Name = "mantain_type";
            this.mantain_type.ReadOnly = true;
            this.mantain_type.Width = 96;
            // 
            // mantain_area
            // 
            this.mantain_area.DataPropertyName = "mantain_area";
            this.mantain_area.HeaderText = "Maintain Area";
            this.mantain_area.Name = "mantain_area";
            this.mantain_area.ReadOnly = true;
            this.mantain_area.Width = 95;
            // 
            // problem_desc
            // 
            this.problem_desc.DataPropertyName = "problem_desc";
            this.problem_desc.HeaderText = "Problem";
            this.problem_desc.Name = "problem_desc";
            this.problem_desc.ReadOnly = true;
            this.problem_desc.Width = 250;
            // 
            // approx_cost
            // 
            this.approx_cost.DataPropertyName = "approx_cost";
            this.approx_cost.HeaderText = "Aprox Cost";
            this.approx_cost.Name = "approx_cost";
            this.approx_cost.ReadOnly = true;
            this.approx_cost.Width = 95;
            // 
            // mantain_Month
            // 
            this.mantain_Month.DataPropertyName = "mantain_Month";
            this.mantain_Month.HeaderText = "Maintain Month";
            this.mantain_Month.Name = "mantain_Month";
            this.mantain_Month.ReadOnly = true;
            this.mantain_Month.Width = 96;
            // 
            // res_unitID
            // 
            this.res_unitID.DataPropertyName = "res_unitID";
            this.res_unitID.HeaderText = "Resident ID";
            this.res_unitID.Name = "res_unitID";
            this.res_unitID.ReadOnly = true;
            this.res_unitID.Width = 95;
            // 
            // owner_Id_tenant_Id
            // 
            this.owner_Id_tenant_Id.DataPropertyName = "owner_Id_tenant_Id";
            this.owner_Id_tenant_Id.HeaderText = "Owner/Tenant ID";
            this.owner_Id_tenant_Id.Name = "owner_Id_tenant_Id";
            this.owner_Id_tenant_Id.ReadOnly = true;
            // 
            // frmViewMaintainDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 624);
            this.Controls.Add(this.bunViewMaintainDetails);
            this.Controls.Add(this.txtSearchdetails);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Name = "frmViewMaintainDetails";
            this.Text = "frmViewMaintainDetails";
            this.Load += new System.EventHandler(this.frmViewMaintainDetails_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewMaintainDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunViewMaintainDetails;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchdetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mantain_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn request_datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn mantain_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn mantain_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn problem_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn approx_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn mantain_Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_unitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_Id_tenant_Id;
    }
}