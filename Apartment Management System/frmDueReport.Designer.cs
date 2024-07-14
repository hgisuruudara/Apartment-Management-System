namespace Apartment_Management_System
{
    partial class frmDueReport
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
            this.tbl_addPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Duepayments = new Apartment_Management_System.Duepayments();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_addPaymentTableAdapter = new Apartment_Management_System.DuepaymentsTableAdapters.tbl_addPaymentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_addPaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duepayments)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_addPaymentBindingSource
            // 
            this.tbl_addPaymentBindingSource.DataMember = "tbl_addPayment";
            this.tbl_addPaymentBindingSource.DataSource = this.Duepayments;
            // 
            // Duepayments
            // 
            this.Duepayments.DataSetName = "Duepayments";
            this.Duepayments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1197, 84);
            this.panel2.TabIndex = 149;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(35, 21);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(404, 40);
            this.label12.TabIndex = 0;
            this.label12.Text = "DUE PAYMENTS REPORT";
            // 
            // reportViewer2
            // 
            this.reportViewer2.BackColor = System.Drawing.Color.WhiteSmoke;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_addPaymentBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Apartment_Management_System.DuePayments.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(59, 140);
            this.reportViewer2.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1061, 576);
            this.reportViewer2.TabIndex = 150;
            // 
            // tbl_addPaymentTableAdapter
            // 
            this.tbl_addPaymentTableAdapter.ClearBeforeFill = true;
            // 
            // frmDueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1197, 768);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDueReport";
            this.Text = "frmDueReport";
            this.Load += new System.EventHandler(this.frmDueReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_addPaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duepayments)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource tbl_addPaymentBindingSource;
        private Duepayments Duepayments;
        private DuepaymentsTableAdapters.tbl_addPaymentTableAdapter tbl_addPaymentTableAdapter;
    }
}