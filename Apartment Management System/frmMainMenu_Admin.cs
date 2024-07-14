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
    public partial class frmMainMenu_Admin : Form
    {
        public frmMainMenu_Admin()
        {
            InitializeComponent();
            CustomizeDesign();
        
        }
        private void CustomizeDesign()
        {
            panelSubmenuManageEmployee.Visible = false;
            panelSubmenuMonitor.Visible = false;
          

            // customize designing
        }

        private void hideSubMenu()
        {
            if (panelSubmenuManageEmployee.Visible == true)
                panelSubmenuManageEmployee.Visible = false;
            if (panelSubmenuMonitor.Visible == true)
                panelSubmenuMonitor.Visible = false;
           


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
            openChildFormInPanel(new frmDashBoardAdmin());
            
            sidepanelmark.Height = btnDashboard.Height;//Side panel
            sidepanelmark.Top = btnDashboard.Top;
            hideSubMenu();
        }

        private void btnUserAccount_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuManageEmployee);

            sidepanelmark.Height = btnUserAccount.Height;//Side panel
            sidepanelmark.Top = btnUserAccount.Top;
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuMonitor);

            sidepanelmark.Height = btnMonitor.Height;//Side panel
            sidepanelmark.Top = btnMonitor.Top;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            sidepanelmark.Height = btnAddUser.Height;//Side panel
            
            openChildFormInPanel(new frmCreateAccount());
            hideSubMenu();
        }

        private void btnViewAccDetails_Click(object sender, EventArgs e)
        {
            sidepanelmark.Height = btnViewAccDetails.Height;//Side panel
          
            openChildFormInPanel(new frmViewAccountDetails());
            hideSubMenu();
        }

        private void btnViewOwners_Click(object sender, EventArgs e)
        {
            sidepanelmark.Height = btnViewOwners.Height;//Side panel
            
            openChildFormInPanel(new frmViewOwners());
            hideSubMenu();
        }

        private void btnViewTenants_Click(object sender, EventArgs e)
        {
            sidepanelmark.Height = btnViewTenants.Height;//Side panel
        
            openChildFormInPanel(new frmViewTenants());
            hideSubMenu();
        }

        private void btnViewApartments_Click(object sender, EventArgs e)
        {
            sidepanelmark.Height = btnViewApartments.Height;//Side panel
       
            openChildFormInPanel(new frmViewApartmentDetails());
            hideSubMenu();
        }

        private void btViewMaintainDetails_Click(object sender, EventArgs e)
        {
            sidepanelmark.Height = btViewMaintainDetails.Height;//Side panel
            
            openChildFormInPanel(new frmViewMaintainDetails());
            hideSubMenu();
        }

        private void btnViewSecDetails_Click(object sender, EventArgs e)
        {
            sidepanelmark.Height = btnViewSecDetails.Height;//Side panel
            
            openChildFormInPanel(new frmViewSecDetails());
            hideSubMenu();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            sidepanelmark.Height = btnHistory.Height;//Side panel
            sidepanelmark.Top = btnHistory.Top;
            openChildFormInPanel(new frmViewHistory());
        }

        private void frmMainMenu_Admin_Load(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmDashBoardAdmin());
        }
    }
}
