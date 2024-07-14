using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Apartment_Management_System
{
    public partial class frmIncomeReport : Form
    {
        public frmIncomeReport()
        {
            InitializeComponent();
        }

        private void frmIncomeReport_Load(object sender, EventArgs e)
        {

            this.tbl_addPaymentTableAdapter.Fill(this.incomeReport.tbl_addPayment);

            this.reportViewer1.RefreshReport();
           

        }
    }
}
