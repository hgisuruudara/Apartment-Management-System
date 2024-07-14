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
    public partial class frmMainMenu_Clerk : Form
    {
        public frmMainMenu_Clerk()
        {
            InitializeComponent();
            CustomizeDesign();
          
        }
       
        private void CustomizeDesign()
        {

            panelSubmenuPayment.Visible = false;
            panelSubmenuApartments.Visible = false;
            panelSubmenuOwner.Visible = false;
            


            // customize designing
        }

        private void hideSubMenu()
        {


            if (panelSubmenuPayment.Visible == true)
                panelSubmenuPayment.Visible = false;
            if (panelSubmenuApartments.Visible == true)
                panelSubmenuApartments.Visible = false;
            if (panelSubmenuOwner.Visible == true)
                panelSubmenuOwner.Visible = false;




        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }





        private void frmMainMenu_Clerk_Load(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmDashBoardClerkCashier ());

            sidepanelmark.Height = btnDashboard.Height;//Side panel
            sidepanelmark.Top = btnDashboard.Top;


        }



        private void btnViewPayments_Click(object sender, EventArgs e)
        {
            sidepanelmark.Height = btnViewPayments.Height;//Side panel

            openChildFormInPanel(new frmViewPayHistory());
            hideSubMenu();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            openChildFormInPanel(new frmDashBoardClerkCashier());
            
            
            sidepanelmark.Height = btnDashboard.Height;//Side panel
            sidepanelmark.Top = btnDashboard.Top;
            hideSubMenu();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuPayment);

            sidepanelmark.Height = btnPayment.Height;//Side panel
            sidepanelmark.Top = btnPayment.Top;
        }

        private void btnAddpay_Click(object sender, EventArgs e)
        {
            sidepanelmark.Height = btnAddpay.Height;//Side panel

            openChildFormInPanel(new frmPayment());
            hideSubMenu();
        }

        private void btnPaymentHist_Click(object sender, EventArgs e)
        {
            sidepanelmark.Height = btnPaymentHist.Height;//Side panel

            openChildFormInPanel(new frmViewPayHistory());
            hideSubMenu();
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuApartments);

            sidepanelmark.Height = btnMonitor.Height;//Side panel
            sidepanelmark.Top = btnMonitor.Top;
        }

        private void btnAddApartments_Click(object sender, EventArgs e)
        {
            sidepanelmark.Height = btnAddApartments.Height;//Side panel

            openChildFormInPanel(new frmAddApartment());
            hideSubMenu();
        }

        private void btnviewApartDetails_Click(object sender, EventArgs e)
        {
            sidepanelmark.Height = btnviewApartDetails.Height;//Side panel

            openChildFormInPanel(new frmViewApartmentDetails());
            hideSubMenu();
        }

        private void btnAddResident_Click(object sender, EventArgs e)
        {
            sidepanelmark.Height = btnAddResident.Height;//Side panel

            openChildFormInPanel(new frmAddResident());
            hideSubMenu();
        }

        private void btnviewResidents_Click(object sender, EventArgs e)
        {
            sidepanelmark.Height = btnviewResidents.Height;//Side panel

            openChildFormInPanel(new frmViewResidentDetail());
            hideSubMenu();
        }

        private void btnMaintanDetails_Click(object sender, EventArgs e)
        {
            sidepanelmark.Height = btnMaintanDetails.Height;//Side panel

            openChildFormInPanel(new frmRequestMonthlyMaintain());
        }

        private void btnOwnerTenant_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuOwner);

            sidepanelmark.Height = btnOwnerTenant.Height;//Side panel
            sidepanelmark.Top = btnOwnerTenant.Top;
        }

        private void btnEditOwners_Click(object sender, EventArgs e)
        {
            sidepanelmark.Height = btnEditOwners.Height;//Side panel

            openChildFormInPanel(new frmEditOwner());
            hideSubMenu();
        }

        private void btnViewOwners_Click_1(object sender, EventArgs e)
        {
            sidepanelmark.Height = btnViewOwners.Height;//Side panel

            openChildFormInPanel(new frmViewOwners());
            hideSubMenu();
        }

        private void btnEditTenants_Click(object sender, EventArgs e)
        {
            sidepanelmark.Height = btnEditTenants.Height;//Side panel

            openChildFormInPanel(new frmEditTenant());
            hideSubMenu();
        }

        private void btnViewTenants_Click_1(object sender, EventArgs e)
        {
            sidepanelmark.Height = btnViewTenants.Height;//Side panel

            openChildFormInPanel(new frmViewTenants());
            hideSubMenu();
        }

        private void btnViewPayments_Click_1(object sender, EventArgs e)
        {
            sidepanelmark.Height = btnMaintanDetails.Height;//Side panel

            openChildFormInPanel(new frmAddSecurityGuard());
        }
    }
}
