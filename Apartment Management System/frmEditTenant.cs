using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Apartment_Management_System
{
    public partial class frmEditTenant : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand com;
        DialogResult res;
        public frmEditTenant()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);
        }

 

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string tid = lblTenId.Text;
            res = MessageBox.Show("Do  you want to Delete Tenant " + tid + "?", "DELETE RECORDS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    Tenant delten = new Tenant();
                    int result = delten.deleteTenant(tid);
                    if (result == 1)
                    {
                        MessageBox.Show("Record Deleted Successfully", "DELETE SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        insertDelResHistory();
                        clear();
                    }
                    else if (result == 0)
                    {
                        MessageBox.Show("Record Deletion Unsuccessful", "INVALID TRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"INVALID TRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clear()
            {
                    lblTenId.Text = "TEN/00000";
                    lblRegDate.Text = "yyyy-mm-dd";
                    txtResID.Text = "";
                    txtTitle.Text ="";
                    txtTenFn.Text="";
                    txtTenLn.Text="";
                    txtNic.Text="";
                    txtMobile.Text="";
                    txtEmail.Text="";

                  btnSearch.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
             }


        private void btnSearchDetails_Click(object sender, EventArgs e)
        {
            string SearchText = txtSearchdetails.Text;
            if (SearchText == "" || SearchText == "ENTER TENANT ID TO SEARCH")
            {
                MessageBox.Show("Enter an Valid Tenant ID to Search", "Invalid Search Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
                return;
            }
            try
            {
                Tenant searten = new Tenant();
                int result = searten.searchTenant(txtSearchdetails.Text);
                if (result == 1)
                {
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnClear.Enabled = true;

                    lblTenId.Text = searten.Tenid;
                    lblRegDate.Text = searten.Regdate;
                    txtResID.Text = searten.Resid;
                    txtTitle.Text =searten.Tentitle;
                    txtTenFn.Text=searten.Tenfname;
                    txtTenLn.Text=searten.Tenlname;
                    txtNic.Text=searten.Tennic;
                    txtMobile.Text=searten.Tencontact;
                    txtEmail.Text=searten.Tenemail;
                    

                    txtSearchdetails.Text = "ENTER TENANT ID TO SEARCH";

                }
                else if (result == 0)
                {
                    MessageBox.Show("Enter an Valid Tenant ID to Search", "Invalid Search Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "INVALID TRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   

        private void cmbTitle_DropDownClosed(object sender, EventArgs e)
        {


        }

        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            res = MessageBox.Show("Do  you want Clear All the Fields", "CLEAR RECORDS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                clear();
            }
            else if (res == DialogResult.No)
            {
                return;
            }
        }

        public void insertUpResHistory() // Insert log Task When a record is updated
        {
            try
            {
                con.Open();
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + " Tenant : " + lblTenId.Text + " is Successfully Updated" + "', '" + DateTime.Now.ToString() + "', '" + "Cashier/Clerk" + "')";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {

                con.Close();

            }

        }


        public void insertDelResHistory() // Insert log Task When a record is updated
        {
            try
            {
                con.Open();
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + " Tenant : " + lblTenId.Text + " is Successfully Deleted" + "', '" + DateTime.Now.ToString() + "', '" + "Cashier/Clerk" + "')";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {

                con.Close();

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string tid = lblTenId.Text;
            res = MessageBox.Show("Do  you want to update Tenant" + tid + "?", "UPDATE RECORDS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                 {
                    Tenant updaten = new Tenant();

                    updaten.Tenid = lblTenId.Text;
                    updaten.Regdate = lblRegDate.Text;
                    updaten.Resid = txtResID.Text;
                    updaten.Tentitle = txtTitle.Text;
                    updaten.Tenfname = txtTenFn.Text;
                    updaten.Tenlname = txtTenLn.Text;
                    updaten.Tennic=txtNic.Text;
                    updaten.Tencontact= txtMobile.Text;
                    updaten.Tenemail = txtEmail.Text;



                    int result = updaten.updateTenant();
                    if (result == 1)
                    {
                        MessageBox.Show("Tenant:" + tid + " Record updated Successfully", "UPDATE SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        insertUpResHistory();
                        clear();
                        txtSearchdetails.Focus();
                    }
                    else if (result == 0)
                    {
                        MessageBox.Show("Record Updated Unsuccessful", "INVALID TRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                 }
                 catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        

    }
}
