namespace Apartment_Management_System
{
    partial class AvailableResidentReport
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
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ResidentDetailsrpt = new Apartment_Management_System.ResidentDetailsrpt();
            this.tbl_addResidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_addResidentsTableAdapter = new Apartment_Management_System.ResidentDetailsrptTableAdapters.tbl_addResidentsTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResidentDetailsrpt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_addResidentsBindingSource)).BeginInit();
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
            this.label12.Size = new System.Drawing.Size(402, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "AVAILABLE RESIDENT REPORT";
            // 
            // reportViewer3
            // 
            this.reportViewer3.BackColor = System.Drawing.Color.WhiteSmoke;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_addResidentsBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Apartment_Management_System.AvailableResidentReport.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(44, 117);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(796, 468);
            this.reportViewer3.TabIndex = 148;
            // 
            // ResidentDetailsrpt
            // 
            this.ResidentDetailsrpt.DataSetName = "ResidentDetailsrpt";
            this.ResidentDetailsrpt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_addResidentsBindingSource
            // 
            this.tbl_addResidentsBindingSource.DataMember = "tbl_addResidents";
            this.tbl_addResidentsBindingSource.DataSource = this.ResidentDetailsrpt;
            // 
            // tbl_addResidentsTableAdapter
            // 
            this.tbl_addResidentsTableAdapter.ClearBeforeFill = true;
            // 
            // AvailableResidentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(898, 624);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.panel2);
            this.Name = "AvailableResidentReport";
            this.Text = "AvailableResidentReport";
            this.Load += new System.EventHandler(this.AvailableResidentReport_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResidentDetailsrpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_addResidentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource tbl_addResidentsBindingSource;
        private ResidentDetailsrpt ResidentDetailsrpt;
        private ResidentDetailsrptTableAdapters.tbl_addResidentsTableAdapter tbl_addResidentsTableAdapter;
    }
}