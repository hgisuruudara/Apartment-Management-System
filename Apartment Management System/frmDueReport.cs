using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartment_Management_System
{
    public partial class frmDueReport : Form
    {
        public frmDueReport()
        {
            InitializeComponent();
        }

        private void frmDueReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Duepayments.tbl_addPayment' table. You can move, or remove it, as needed.
            this.tbl_addPaymentTableAdapter.Fill(this.Duepayments.tbl_addPayment);

            this.reportViewer2.RefreshReport();
        }
    }
}
