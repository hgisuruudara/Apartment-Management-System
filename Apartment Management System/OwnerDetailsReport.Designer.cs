namespace Apartment_Management_System
{
    partial class OwnerDetailsReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new Apartment_Management_System.DataSet1();
            this.tbl_ownerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ownerDetailsTableAdapter = new Apartment_Management_System.DataSet1TableAdapters.tbl_ownerDetailsTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ownerDetailsBindingSource)).BeginInit();
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
            this.panel2.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(26, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(332, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "OWNER DETAILS REPORT";
            // 
            // reportViewer4
            // 
            this.reportViewer4.BackColor = System.Drawing.Color.WhiteSmoke;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_ownerDetailsBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Apartment_Management_System.OwnerDetailsReport.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(47, 119);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(796, 468);
            this.reportViewer4.TabIndex = 149;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ownerDetailsBindingSource
            // 
            this.tbl_ownerDetailsBindingSource.DataMember = "tbl_ownerDetails";
            this.tbl_ownerDetailsBindingSource.DataSource = this.DataSet1;
            // 
            // tbl_ownerDetailsTableAdapter
            // 
            this.tbl_ownerDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // OwnerDetailsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(898, 624);
            this.Controls.Add(this.reportViewer4);
            this.Controls.Add(this.panel2);
            this.Name = "OwnerDetailsReport";
            this.Text = "OwnerDetailsReport";
            this.Load += new System.EventHandler(this.OwnerDetailsReport_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ownerDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource tbl_ownerDetailsBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.tbl_ownerDetailsTableAdapter tbl_ownerDetailsTableAdapter;
    }
}