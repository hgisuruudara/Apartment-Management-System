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
    public partial class frmAddResident : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand com;
        DialogResult res;

        public frmAddResident()
        {
            InitializeComponent();
                     
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);

            Resident res = new Resident();
            lblResId.Text = res.getResId();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            frmViewApartmentDetails frmap = new frmViewApartmentDetails();
            frmap.Show();
        }


        private void clear()
        {
            //Get New Res ID after Clearing
            Resident res = new Resident();
            lblResId.Text = res.getResId();

            //Clear the fields

            cmbApartType.Items.Clear();
            txtSearchdetails.Text = "ENTER RES ID TO SEARCH";
            loadApartTypes();
            cmbApartNa.Items.Clear();
            txtApartmentID.Text = "";
            txtApartLocation.Text = "";
            txtNoLevels.Text = "";
            txtAvailUnits.Text= "";
            txtNoofUnits.Text = "";
           txtResiNa.Text= "";
           txtBlockNa.Text= "";
           txtPurPrice.Text= "";
           txtRentPri.Text= "";
           txtNoofRooms.Text= "";
           txtNoofBath.Text = "";
           txtResiStatus.Text = "";

            btnSearch.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnCreateAcc.Enabled = true;


        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {

            
            if (cmbApartType.Text == "" || cmbApartNa.Text == "" || txtApartmentID.Text == "" || txtApartLocation.Text == "" || txtNoLevels.Text == "" || txtAvailUnits.Text== "" || txtNoofUnits.Text == "")
            {
                MessageBox.Show("Select Apartment Details before inserting", "INVALID TRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtResiNa.Text, @"^[a-zA-Z0-9\/\-\.\s]*$").Success || txtResiNa.Text == "")
            {
                MessageBox.Show("Enter an Valid Resident Name ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtBlockNa.Text, @"^[a-zA-Z0-9\/\-\.\s]*$").Success || txtBlockNa.Text == "")
            {
                MessageBox.Show("Enter a Valid Block Name", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtPurPrice.Text, @"^[0-9\.\s]*$").Success || txtPurPrice.Text == "")
            {
                MessageBox.Show("Enter a valid Purchase Amount ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtRentPri.Text, @"^[0-9\.\s]*$").Success || txtRentPri.Text == "")
            {
                MessageBox.Show("Enter valid Rent Amount ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtNoofRooms.Text, @"^[0-9\.\s]*$").Success || txtNoofRooms.Text == "")
            {
                MessageBox.Show("Enter valid Number of Rooms ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtNoofBath.Text, @"^[0-9\.\s]*$").Success || txtNoofBath.Text == "")
            {
                MessageBox.Show("Enter valid Number of Rooms ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtResiStatus.Text, @"^[a-zA-Z0-9\s\/\-\.]*$").Success || txtResiStatus.Text == "")
            {
                MessageBox.Show("Status Format is incorrect ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            Resident res = new Resident();

            res.Resid = lblResId.Text;
            res.Apartid = txtApartmentID.Text;
            res.Resname=txtResiNa.Text;
            res.Reslocation=txtBlockNa.Text;
            res.Respurprice = decimal.Parse(txtPurPrice.Text);
            res.Resrentprice = decimal.Parse(txtRentPri.Text);
            res.Resnoofrooms = int.Parse(txtNoofRooms.Text);
            res.Resnoofbath = int.Parse(txtNoofBath.Text);
            res.Resstatus = txtResiStatus.Text;



            try
            {
                int result = res.insertResident();

                if (result == 1)
                {

                    updateAvaUnit();
                    MessageBox.Show("Resident : " + res.Resid + " Successfully Inserted", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    insertAddResHistory();
                    clear();
                }
                else
                {
                    MessageBox.Show("Apartment Creation is Unsuccessfull", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {                         

                lblResId.Text = res.getResId();
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }


        public void updateAvaUnit()
                {
                    try
                    {
                        con.Open();
                        string sql = "UPDATE tbl_addApartments SET apart_unitAvailaStatus=apart_unitAvailaStatus +1 WHERE apart_id='" + txtApartmentID.Text + "'";
                        com = new SqlCommand(sql, con);
                        com.ExecuteNonQuery();
                    }
                     catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }


        public void insertAddResHistory()
        {
           try
            {
                con.Open();
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + "Resident Unit : " + lblResId.Text + " is Successfully Inserted" + "', '" + DateTime.Now.ToString() + "', '" + "Manager/Clerk" + "')";
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



        public void insertUpResHistory() // Insert log Task When a record is updated
        {
            try
            {
                con.Open();
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + "Resident Unit : " + lblResId.Text + " is Successfully Updated" + "', '" + DateTime.Now.ToString() + "', '" + "Manager/Clerk" + "')";
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
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + " Resident : " + lblResId.Text + " is Successfully Deleted" + "', '" + DateTime.Now.ToString() + "', '" + "Manager/Clerk" + "')";
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




        private void cmbApartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            try
            {
                txtApartmentID.Text = "";
                txtApartLocation.Text = "";
                txtNoLevels.Text = "";
                txtNoofUnits.Text = "";
                txtAvailUnits.Text = "";

                if (cmbApartType.Text == "Luxury")
                {
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
                else if (cmbApartType.Text == "Semi Luxury")
                {
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

                else if (cmbApartType.Text == "Economy")
                {
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
        private void frmAddResident_Load(object sender, EventArgs e)
        {
            loadApartTypes();
        }

        public void loadApartTypes()
        {
            cmbApartType.Text = "Select Apartment Type";

            cmbApartType.Items.Add("Luxury"); // add item to combo box

            cmbApartType.Items.Add("Semi Luxury"); // add item to combo box

            cmbApartType.Items.Add("Economy"); // add item to combo box

            cmbApartNa.Text = "Select Apartment Name";
        }

        private void cmbApartNa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "SELECT apart_id,apart_location,apart_levels,apart_residentialunits,apart_unitAvailaStatus FROM tbl_addApartments WHERE apart_name ='" + cmbApartNa.Text + "'";
                SqlDataReader dr = new SqlCommand(sql, con).ExecuteReader();
                while (dr.Read())
                {
                    txtApartmentID.Text = (dr["apart_id"].ToString());
                    txtApartLocation.Text = (dr["apart_location"].ToString());
                    txtNoLevels.Text = (dr["apart_levels"].ToString());
                    txtNoofUnits.Text = (dr["apart_residentialunits"].ToString());
                    txtAvailUnits.Text = (dr["apart_unitAvailaStatus"].ToString());

                    txtResiNa.Text = cmbApartNa.Text;


                }

                dr.Close();

                if (txtNoofUnits.Text == txtAvailUnits.Text)
                {
                    MessageBox.Show("Number of Residents able to Exsist in Apartment "+cmbApartNa.Text+" Reached", "RESIDENT UNITS REACHED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                }
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

        private void btnCancel_Click(object sender, EventArgs e)
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

        private void txtResiStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResiStatus_Click(object sender, EventArgs e)
        {
            txtResiStatus.Text = "Available";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string rid = lblResId.Text;
            res = MessageBox.Show("Do  you want to update " + rid + "?", "UPDATE RECORDS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {

                    Resident upres = new Resident();

                    upres.Resid = lblResId.Text;
                    upres.Apartid = txtApartmentID.Text;
                    upres.Resname = txtResiNa.Text;
                    upres.Reslocation = txtBlockNa.Text;
                    upres.Respurprice = decimal.Parse(txtPurPrice.Text);
                    upres.Resrentprice = decimal.Parse(txtRentPri.Text);
                    upres.Resnoofrooms = int.Parse(txtNoofRooms.Text);
                    upres.Resnoofbath = int.Parse(txtNoofBath.Text);
                    upres.Resstatus = txtResiStatus.Text;




                    int result = upres.updateResident();
                    if (result == 1)
                    {

                        MessageBox.Show("Resident :"+lblResId.Text+" updated Successfully", "UPDATE SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        insertUpResHistory();
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
            string rid = lblResId.Text;
            res = MessageBox.Show("Do you want to Delete Resident " + rid + "?", "DELETE RECORD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    Resident delres = new Resident();
                    int result = delres.deleteResident(rid);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string SearchText = txtSearchdetails.Text;
            if (SearchText == "" || SearchText == "ENTER RES ID TO SEARCH")
            {
                MessageBox.Show("Enter an Valid Resident ID to Search", "Invalid Search Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
                return;
            }
            try

            {
                btnCreateAcc.Enabled = false;
                Resident ressea = new Resident();
                int result = ressea.searchResidents(txtSearchdetails.Text);
                if (result == 1)
                {
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = true;

                    lblResId.Text = ressea.Resid;

                    txtResiNa.Text = ressea.Resname;
                    txtBlockNa.Text = ressea.Reslocation;
                    txtPurPrice.Text = ressea.Respurprice.ToString();
                    txtRentPri.Text = ressea.Resrentprice.ToString();
                    txtNoofRooms.Text = ressea.Resnoofrooms.ToString();
                    txtNoofBath.Text = ressea.Resnoofbath.ToString();
                    txtResiStatus.Text = ressea.Resstatus;

                    cmbApartType.Text = ressea.Aparttype;
                    cmbApartNa.Text = ressea.Apartname;
                    txtApartmentID.Text = ressea.Apartid;
                    txtApartLocation.Text = ressea.Apartlocation;
                    txtNoLevels.Text = ressea.Apartlevel.ToString();
                    txtNoofUnits.Text = ressea.Apartresidentunit.ToString();
                    txtAvailUnits.Text = ressea.Apartunitstatus.ToString();
                    
                    
                    

                    txtSearchdetails.Text = "ENTER RES ID TO SEARCH";

                }
                else if (result == 0)
                {
                    MessageBox.Show("Enter an Valid Resident ID to Search", "Invalid Search Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "INVALID TRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
