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
    public partial class OwnerDetailsReport : Form
    {
        public OwnerDetailsReport()
        {
            InitializeComponent();
        }

        private void OwnerDetailsReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.tbl_ownerDetails' table. You can move, or remove it, as needed.
            this.tbl_ownerDetailsTableAdapter.Fill(this.DataSet1.tbl_ownerDetails);
            this.reportViewer4.RefreshReport();

        }
    }
}
