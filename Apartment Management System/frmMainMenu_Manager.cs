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
    public partial class frmMainMenu_Manager : Form
    {
        public frmMainMenu_Manager()
        {
            InitializeComponent();
            CustomizeDesign();
            
        }
        private void CustomizeDesign()
        {
            panelSubmenuManageEmployee.Visible = false;
            panelSubmenuApartments.Visible = false;
            panelSubmenuOwner.Visible = false;
            panelSubmenuReports.Visible = false;


            // customize designing
        }

        private void hideSubMenu()
        {
            if (panelSubmenuManageEmployee.Visible == true)
                panelSubmenuManageEmployee.Visible = false;

            if (panelSubmenuApartments.Visible == true)
                panelSubmenuApartments.Visible = false;

            if (panelSubmenuOwner.Visible==true)
                panelSubmenuOwner.Visible = false;


            if (panelSubmenuReports.Visible == true)
                panelSubmenuReports.Visible = false;
      




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
            openChildFormInPanel(new frmDashBoardManager());


            sidepanelmark1.Height = btnDashboard.Height;//Side panel
            sidepanelmark1.Top = btnDashboard.Top;
            hideSubMenu();
        }

        private void btnUserAccount_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuManageEmployee);

            sidepanelmark1.Height = btnUserAccount.Height;//Side panel
            sidepanelmark1.Top = btnUserAccount.Top;
        }

 

        private void btnViewAccDetails_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnViewAccDetails.Height;//Side panel

            openChildFormInPanel(new frmViewAccountDetails());
            hideSubMenu();
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuApartments);

            sidepanelmark1.Height = btnMonitor.Height;//Side panel
            sidepanelmark1.Top = btnMonitor.Top;
        }



        

  


    

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void frmMainMenu_Manager_Load(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmDashBoardManager());
        }

        private void btViewMaintainDetails_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddApartments_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnAddApartments.Height;//Side panel

            openChildFormInPanel(new frmAddApartment());
            hideSubMenu();
        }

        private void btnviewApartDetails_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnviewApartDetails.Height;//Side panel

            openChildFormInPanel(new frmViewApartmentDetails());
            hideSubMenu();
        }

        private void btnAddResident_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnAddResident.Height;//Side panel

            openChildFormInPanel(new frmAddResident());
            hideSubMenu();
        }



        private void btnMaintanDetails_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnMaintanDetails.Height;//Side panel

            openChildFormInPanel(new frmViewMaintainDetails());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuOwner);

            sidepanelmark1.Height = button4.Height;//Side panel
            sidepanelmark1.Top = button4.Top;
        }

        private void btnViewOwners_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnViewOwners.Height;//Side panel

            openChildFormInPanel(new frmViewOwners());
            hideSubMenu();
        }

        private void btnViewTenants_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnViewTenants.Height;//Side panel

            openChildFormInPanel(new frmViewTenants());
            hideSubMenu();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuReports);

            sidepanelmark1.Height = btnReports.Height;//Side panel
            sidepanelmark1.Top = btnReports.Top;
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnIncome.Height;//Side panel

            openChildFormInPanel(new frmIncomeReport());
            hideSubMenu();
        }

        private void btndue_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btndue.Height;//Side panel

            openChildFormInPanel(new frmDueReport());
            hideSubMenu();
        }

        private void btnViewPayments_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnViewPayments.Height;//Side panel

            openChildFormInPanel(new frmViewPayHistory());
            
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnHistory.Height;//Side panel

            openChildFormInPanel(new frmViewHistory());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = button1.Height;//Side panel

            openChildFormInPanel(new frmViewSecDetails());
        }

        private void btnviewResidents_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnviewResidents.Height;//Side panel

            openChildFormInPanel(new frmViewResidentDetail());
            hideSubMenu();
        }

        private void sidepanelmark1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAvaResiReport_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btndue.Height;//Side panel

            openChildFormInPanel(new AvailableResidentReport());
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btndue.Height;//Side panel

            openChildFormInPanel(new OwnerDetailsReport());
            hideSubMenu();
        }

     

    

    

   

   

      



        

     




    }
}
