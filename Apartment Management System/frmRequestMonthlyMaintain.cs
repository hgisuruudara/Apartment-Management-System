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
    public partial class frmRequestMonthlyMaintain : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand com;
        DialogResult res;
        public frmRequestMonthlyMaintain()
        {
            InitializeComponent();

            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);

            Maintanance reqid = new Maintanance();
            lblReqId.Text = reqid.getReqId();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCustNa_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFn_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadApartTypes()
        {
            cmbApartType.Text = "Select Apartment Type";

            cmbApartType.Items.Add("Luxury"); // add item to combo box

            cmbApartType.Items.Add("Semi Luxury"); // add item to combo box

            cmbApartType.Items.Add("Economy"); // add item to combo box

            cmbApartNa.Text = "Select Apartment Name";
        }

        public void loadMonths()
        {

            cmbMaintainMonth.Text = "Select Month";
            cmbMaintainMonth.Items.Add("January"); // add item to combo box
            cmbMaintainMonth.Items.Add("February"); // add item to combo box
            cmbMaintainMonth.Items.Add("March"); // add item to combo box
            cmbMaintainMonth.Items.Add("April."); // add item to combo box
            cmbMaintainMonth.Items.Add("May"); // add item to combo box
            cmbMaintainMonth.Items.Add("June"); // add item to combo box
            cmbMaintainMonth.Items.Add("July"); // add item to combo box
            cmbMaintainMonth.Items.Add("August"); // add item to combo box
            cmbMaintainMonth.Items.Add("September"); // add item to combo box
            cmbMaintainMonth.Items.Add("October"); // add item to combo box
            cmbMaintainMonth.Items.Add("November"); // add item to combo box
            cmbMaintainMonth.Items.Add("December"); // add item to combo box
        }


        public void loadMainType()
        {

            cmbMaitainType.Text = "Select Maintain Type";
            cmbMaitainType.Items.Add("Rebuild"); // add item to combo box
            cmbMaitainType.Items.Add("Restructure"); // add item to combo box
            cmbMaitainType.Items.Add("Restore"); // add item to combo box
            cmbMaitainType.Items.Add("Replace"); // add item to combo box
            cmbMaitainType.Items.Add("Remove"); // add item to combo box
            cmbMaitainType.Items.Add("Color Wash"); // add item to combo box
            cmbMaitainType.Items.Add("Varnish"); // add item to combo box
        }


        public void loadMainArea()
        {

            cmbMaintainArea.Text = "Select Maintain Area";
            cmbMaintainArea.Items.Add("Walls"); // add item to combo box
            cmbMaintainArea.Items.Add("Beams"); // add item to combo box
            cmbMaintainArea.Items.Add("Slab"); // add item to combo box
            cmbMaintainArea.Items.Add("Door"); // add item to combo box
            cmbMaintainArea.Items.Add("Window"); // add item to combo box
            cmbMaintainArea.Items.Add("Floor Tiles"); // add item to combo box
            cmbMaintainArea.Items.Add("Floor Cement"); // add item to combo box
            cmbMaintainArea.Items.Add("Remove"); // add item to combo box
            cmbMaintainArea.Items.Add("Water Line"); // add item to combo box
            cmbMaintainArea.Items.Add("Electricity Line"); // add item to combo box
            cmbMaintainArea.Items.Add("Switches"); // add item to combo box
        }

        private void clear()
        {
            //Get New Req ID after Clearing
            Maintanance reqid = new Maintanance();
            lblReqId.Text = reqid.getReqId();

            //Clear the fields

            cmbApartType.Items.Clear();
            txtSearchDetails.Text = "SEARCH TO EDIT REQUEST";
            loadApartTypes();
            cmbApartNa.Items.Clear();
            txtApartmentID.Text = "";
            txtApartLocation.Text = "";
            cmbResiNa.Items.Clear();
            txtResiID.Text = "";
            txtResidentBlock.Text = "";
            cmbMaitainType.Items.Clear();
            loadMainType();

            cmbMaintainArea.Items.Clear();
            loadMainArea();
            txtAproxCost.Text = "0.00";
            cmbMaintainMonth.Items.Clear();
            loadMonths();
            txtProblem.Text = "";

            txtOwnTen.Text = "";

            btnSearch.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnMakeReq.Enabled = true;


        }


        private void frmRequestMonthlyMaintain_Load(object sender, EventArgs e)
        {

            lbldt.Text = DateTime.Now.ToString();
            loadApartTypes();
            loadMonths();
            loadMainType();
            loadMainArea();
        }

        private void cmbApartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtApartmentID.Text = "";
                txtApartLocation.Text = "";

                cmbApartNa.Items.Clear();
                con.Open();
                string sql = "SELECT apart_name FROM tbl_addApartments WHERE apart_type ='" + cmbApartType.Text + "'";
                SqlDataReader dr = new SqlCommand(sql, con).ExecuteReader();
                while (dr.Read())
                {
                    cmbApartNa.Items.Add(dr["apart_name"].ToString());
                }
                dr.Close();
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

        private void cmbApartNa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "SELECT apart_id,apart_location FROM tbl_addApartments WHERE apart_name ='" + cmbApartNa.Text + "'";
                SqlDataReader dr = new SqlCommand(sql, con).ExecuteReader();
                while (dr.Read())
                {
                    txtApartmentID.Text = (dr["apart_id"].ToString());
                    txtApartLocation.Text = (dr["apart_location"].ToString());
                }

                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {

                con.Close();
                loadAvaResidents();
            }

        }


        private void loadAvaResidents()
        {
            try
            {
                cmbResiNa.Items.Clear();
                con.Open();
                string sql = "SELECT res_name FROM tbl_addResidents WHERE apart_id ='" + txtApartmentID.Text + "'";
                SqlDataReader dr = new SqlCommand(sql, con).ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        cmbResiNa.Items.Add(dr.GetValue(0).ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No Residential Units Available", "NO UNITS FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();


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

        private void cmbResiNa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "SELECT res_unitID,res_blockLocation,res_price,res_rentAmt,res_Status, res_noOfRooms,res_noOfBathRooms FROM tbl_addResidents WHERE res_name ='" + cmbResiNa.Text + "'";
                SqlDataReader dr = new SqlCommand(sql, con).ExecuteReader();
                while (dr.Read())
                {
                    txtResiID.Text = (dr["res_unitID"].ToString());
                    txtResidentBlock.Text = (dr["res_blockLocation"].ToString());

                }

                dr.Close();

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string SearchText = txtSearchDetails.Text;
            if (SearchText == "" || SearchText == "SEARCH TO EDIT REQUEST")
            {
                MessageBox.Show("Enter an Valid Resident ID to Search", "Invalid Search Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
                return;
            }
            try
            {
                btnMakeReq.Enabled = false;
                Maintanance mainrqstsea = new Maintanance();
                int result = mainrqstsea.searchMaintenanceReq(txtSearchDetails.Text);
                if (result == 1)
                {
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnClear.Enabled = true;

                    txtResiID.Text = mainrqstsea.Resid;
                    cmbResiNa.Text = mainrqstsea.Resname;
                    txtResidentBlock.Text = mainrqstsea.Reslocation;
                    lbldt.Text = mainrqstsea.Reqdate.ToString();

                    cmbApartType.Text = mainrqstsea.Aparttype;
                    cmbApartNa.Text = mainrqstsea.Apartname;
                    txtApartmentID.Text = mainrqstsea.Apartid;
                    txtApartLocation.Text = mainrqstsea.Apartlocation;

                    txtOwnTen.Text= mainrqstsea.Owntenid;
                    cmbMaitainType.Text= mainrqstsea.Maintaintype;
                    cmbMaintainArea.Text= mainrqstsea.Maintainarea;
                    txtAproxCost.Text = mainrqstsea.Aproxcost.ToString();
                    txtProblem.Text= mainrqstsea.Problemdes;
                    cmbMaintainMonth.Text = mainrqstsea.Maintainmonth;


                 




                    txtSearchDetails.Text = "SEARCH TO EDIT REQUEST";

                }
                else if (result == 0)
                {
                    MessageBox.Show("Enter an Valid Maintenance Request ID to Search", "Invalid Search Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "INVALID TRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void insertAddMainHistory()
        {
            try
            {
                con.Open();
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + " Monthly Mainance Request Unit : " + lblReqId.Text + " is Successfully Inserted" + "', '" + DateTime.Now.ToString() + "', '" + "Cashier/Clerk" + "')";
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



        public void insertUpMainHistory() // Insert log Task When a record is updated
        {
            try
            {
                con.Open();
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + "Monthly Mainance Request Unit : " + lblReqId.Text + " is Successfully Updated" + "', '" + DateTime.Now.ToString() + "', '" + "Cashier/Clerk" + "')";
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



        public void insertDelMainHistory() // Insert log Task When a record is updated
        {
            try
            {
                con.Open();
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + "Monthly Mainance Request Unit : " + lblReqId.Text + " is Successfully Deleted" + "', '" + DateTime.Now.ToString() + "', '" + "Cashier/Clerk" + "')";
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

        private void btnMakeReq_Click(object sender, EventArgs e)
        {

            if (cmbApartType.Text == "" || cmbApartNa.Text == "" || txtApartmentID.Text == "" || txtApartLocation.Text == "")
            {
                MessageBox.Show("Select Apartment Details before inserting", "INVALID TRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbResiNa.Text == "" || txtResiID.Text == "" || txtResidentBlock.Text == "")
            {
                MessageBox.Show("Select Resident Details before inserting", "INVALID TRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (cmbMaitainType.Text == "Select Maintain Type" || cmbMaitainType.Text == "")
            {
                MessageBox.Show("Invalid Maitain Type", "INVALID SELECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (cmbMaintainArea.Text == "Select Maintain Area" || cmbMaintainArea.Text == "")
            {
                MessageBox.Show("Invalid Maitain Area", "INVALID SELECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (cmbMaintainMonth.Text == "Select Month" || cmbMaintainMonth.Text == "")
            {
                MessageBox.Show("Invalid Month", "INVALID SELECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txtOwnTen.Text == "")
            {
                MessageBox.Show("Enter an Valid Owner/Tenant ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtAproxCost.Text, @"^[0-9\.]*$").Success || txtAproxCost.Text == "")
            {
                MessageBox.Show("Enter an Valid Aprroximate Maitenance Cost ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }





            Maintanance insreq = new Maintanance();


            insreq.Reqdate = DateTime.Now;
            insreq.Resid = txtResiID.Text;
            insreq.Owntenid = txtOwnTen.Text;
            insreq.Mid = lblReqId.Text;
            insreq.Maintaintype = cmbMaitainType.Text;
            insreq.Maintainarea = cmbMaintainArea.Text;
            insreq.Aproxcost = decimal.Parse(txtAproxCost.Text);
            insreq.Problemdes = txtProblem.Text;
            insreq.Maintainmonth = cmbMaintainMonth.Text;




            try
            {
                int result = insreq.insertMaintainReq();

                if (result == 1)
                {

                    MessageBox.Show("Monthly Maintenance Request : " + insreq.Mid + " Successfully Inserted", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    insertAddMainHistory();
                    clear();
                }
                else
                {
                    MessageBox.Show("Monthly Maintenance Request is Unsuccessfull", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {

                Maintanance reqid = new Maintanance();
                lblReqId.Text = reqid.getReqId();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbApartType.Text == "" || cmbApartNa.Text == "" || txtApartmentID.Text == "" || txtApartLocation.Text == "")
            {
                MessageBox.Show("Select Apartment Details before inserting", "INVALID TRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbResiNa.Text == "" || txtResiID.Text == "" || txtResidentBlock.Text == "")
            {
                MessageBox.Show("Select Resident Details before inserting", "INVALID TRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (cmbMaitainType.Text == "Select Maintain Type" || cmbMaitainType.Text == "")
            {
                MessageBox.Show("Invalid Maitain Type", "INVALID SELECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (cmbMaintainArea.Text == "Select Maintain Area" || cmbMaintainArea.Text == "")
            {
                MessageBox.Show("Invalid Maitain Area", "INVALID SELECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (cmbMaintainMonth.Text == "Select Month" || cmbMaintainMonth.Text == "")
            {
                MessageBox.Show("Invalid Month", "INVALID SELECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txtOwnTen.Text == "")
            {
                MessageBox.Show("Enter an Valid Owner/Tenant ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtAproxCost.Text, @"^[0-9\.]*$").Success || txtAproxCost.Text == "")
            {
                MessageBox.Show("Enter an Valid Aprroximate Maitenance Cost ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string mid = lblReqId.Text;

            res = MessageBox.Show("Do  you want to update " + mid + "?", "UPDATE RECORDS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {

                    Maintanance requpdt = new Maintanance();

                    requpdt.Mid = lblReqId.Text;                                      
                    requpdt.Maintaintype = cmbMaitainType.Text;
                    requpdt.Maintainarea = cmbMaintainArea.Text;
                    requpdt.Aproxcost = decimal.Parse(txtAproxCost.Text);
                    requpdt.Problemdes = txtProblem.Text;
                    requpdt.Maintainmonth = cmbMaintainMonth.Text;
                    requpdt.Resid = txtResiID.Text;
                    requpdt.Owntenid = txtOwnTen.Text;


                    int result = requpdt.updateMaintenance();
                    if (result == 1)
                    {

                        MessageBox.Show("Monthly Maintenance Request :" + lblReqId.Text + " updated Successfully", "UPDATE SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        insertUpMainHistory();
                        clear();
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
            string mid = lblReqId.Text;

            res = MessageBox.Show("Do you want to Delete Monthly Maintenance Request " + mid + "?", "DELETE RECORD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    Maintanance delreq = new Maintanance();

                    int result = delreq.deleteMaintenance(mid);
                    if (result == 1)
                    {
                        MessageBox.Show("Record Deleted Successfully", "DELETE SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        insertDelMainHistory();
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
