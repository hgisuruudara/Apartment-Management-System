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
    public partial class AvailableResidentReport : Form
    {
        public AvailableResidentReport()
        {
            InitializeComponent();
        }

        private void AvailableResidentReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ResidentDetailsrpt.tbl_addResidents' table. You can move, or remove it, as needed.
            this.tbl_addResidentsTableAdapter.Fill(this.ResidentDetailsrpt.tbl_addResidents);
            this.reportViewer3.RefreshReport();

        }
    }
}
