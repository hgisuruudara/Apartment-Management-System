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
    public partial class frmEditOwner : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand com;
        DialogResult res;
        public frmEditOwner()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clear()
        {
            lblOwnId.Text = "OWN/00000";
            lblRegDate.Text = "yyyy-mm-dd";
            txtResID.Text = "";
            txtTitle.Text = "";
            txtOwnFn.Text = "";
            txtOwnLn.Text = "";
            txtNic.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";

            btnSearch.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string SearchText = txtSearchdetails.Text;
            if (SearchText == "" || SearchText == "ENTER OWNER ID TO SEARCH")
            {
                MessageBox.Show("Enter an Valid Owner ID to Search", "Invalid Search Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
                return;
            }
            try
            {
                Owner searown = new Owner();
                int result = searown.searchOwner(txtSearchdetails.Text);
                if (result == 1)
                {
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnClear.Enabled = true;

                    lblOwnId.Text = searown.Ownid;
                    lblRegDate.Text = searown.Regdate;
                    txtResID.Text = searown.Resid;
                    txtOwnTitle.Text = searown.Owntitle;
                    txtOwnFn.Text = searown.Ownfname;
                    txtOwnLn.Text = searown.Ownlname;
                    txtNic.Text = searown.Ownnic;
                    txtMobile.Text = searown.Owncontact;
                    txtEmail.Text = searown.Ownemail;


                    txtSearchdetails.Text = "ENTER OWNER ID TO SEARCH";

                }
                else if (result == 0)
                {
                    MessageBox.Show("Enter an Valid Owner ID to Search", "Invalid Search Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "INVALID TRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + " Owner : " + lblOwnId.Text + " is Successfully Updated" + "', '" + DateTime.Now.ToString() + "', '" + "Cashier/Clerk" + "')";
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
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + " Owner : " + lblOwnId.Text + " is Successfully Deleted" + "', '" + DateTime.Now.ToString() + "', '" + "Cashier/Clerk" + "')";
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
            string oid = lblOwnId.Text;
            res = MessageBox.Show("Do  you want to update Owner" + oid + "?", "UPDATE RECORDS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    Owner updaown = new Owner();

                    updaown.Ownid = lblOwnId.Text;
                    updaown.Regdate = lblRegDate.Text;
                    updaown.Resid = txtResID.Text;
                    updaown.Owntitle = txtTitle.Text;
                    updaown.Ownfname = txtOwnFn.Text;
                    updaown.Ownlname = txtOwnLn.Text;
                    updaown.Ownnic = txtNic.Text;
                    updaown.Owncontact = txtMobile.Text;
                    updaown.Ownemail = txtEmail.Text;



                    int result = updaown.updateOwner();
                    if (result == 1)
                    {
                        MessageBox.Show("Owner:" + oid + " Record updated Successfully", "UPDATE SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string oid = lblOwnId.Text;
            res = MessageBox.Show("Do  you want to Delete Owner " + oid + "?", "DELETE RECORDS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    Owner delown = new Owner();
                    int result = delown.deleteOwner(oid);
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
                    MessageBox.Show(ex.Message, "INVALID TRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
