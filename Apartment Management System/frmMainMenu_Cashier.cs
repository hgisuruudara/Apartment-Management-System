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
    public partial class frmMainMenu_Cashier : Form
    {
        public frmMainMenu_Cashier()
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmDashBoardClerkCashier());
            sidepanelmark1.Height = btnDashboard.Height;//Side panel
            sidepanelmark1.Top = btnDashboard.Top;
            hideSubMenu();
        }

      

     


        private void btnPayment_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuPayment);

            sidepanelmark1.Height = btnPayment.Height;//Side panel
            sidepanelmark1.Top = btnPayment.Top;
        }

     


        private void frmMainMenu_Cashier_Load(object sender, EventArgs e)
        {

            openChildFormInPanel(new frmDashBoardClerkCashier());
        }


        private void btnviewApartDetails_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnviewApartDetails.Height;//Side panel

            openChildFormInPanel(new frmViewApartmentDetails());
            hideSubMenu();
        }

        private void btnviewResidents_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnviewResidents.Height;//Side panel

            openChildFormInPanel(new frmViewResidentDetail());
            hideSubMenu();
        }

    
        private void btnOwnerTenant_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuOwner);

            sidepanelmark1.Height = btnOwnerTenant.Height;//Side panel
            sidepanelmark1.Top = btnOwnerTenant.Top;
        }

 

        private void btnViewTenants_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnViewTenants.Height;//Side panel

            openChildFormInPanel(new frmViewTenants());
            hideSubMenu();
        }

        private void btnViewOwners_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnViewOwners.Height;//Side panel

            openChildFormInPanel(new frmViewOwners());
            hideSubMenu();
        }

        private void btnEditOwners_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnEditOwners.Height;//Side panel

            openChildFormInPanel(new frmEditOwner());
            hideSubMenu();
        }

        private void btnEditTenants_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnEditTenants.Height;//Side panel

            openChildFormInPanel(new frmEditTenant());
            hideSubMenu();
        }

        private void btnAddpay_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnAddpay.Height;//Side panel
            openChildFormInPanel(new frmPayment());
            hideSubMenu();
        }

        private void btnPaymentHist_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnPaymentHist.Height;//Side panel

            openChildFormInPanel(new frmViewPayHistory());
            hideSubMenu();
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuApartments);

            sidepanelmark1.Height = btnMonitor.Height;//Side panel
            sidepanelmark1.Top = btnMonitor.Top;
        }

        private void btnMaintanDetails_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnMaintanDetails.Height;//Side panel

            openChildFormInPanel(new frmRequestMonthlyMaintain());
        }

        



    }
}
