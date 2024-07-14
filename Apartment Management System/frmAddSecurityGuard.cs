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
    public partial class frmAddSecurityGuard : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand com;
        DialogResult res;
        public frmAddSecurityGuard()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);
        }

        private void frmAddSecurityGuard_Load(object sender, EventArgs e)
        {
            loadTitle();
            loadApartTypes();
            dtDutyOn.Value = DateTime.Today;
            dtDutyOff.Value = DateTime.Today;
        }



        public void loadApartTypes()
        {
            cmbApartType.Text = "Select Apartment Type";

            cmbApartType.Items.Add("Luxury"); // add item to combo box

            cmbApartType.Items.Add("Semi Luxury"); // add item to combo box

            cmbApartType.Items.Add("Economy"); // add item to combo box

            cmbApartNa.Text = "Select Apartment Name";
        }


        public void loadTitle()
        {
            cmbTitle.Text = "Select Title";
            cmbTitle.Items.Add("Mr."); // add item to combo box
            cmbTitle.Items.Add("Mrs."); // add item to combo box
            cmbTitle.Items.Add("Miss."); // add item to combo box
            cmbTitle.Items.Add("Master."); // add item to combo box
            cmbTitle.Items.Add("Rev."); // add item to combo box
            cmbTitle.Items.Add("Dr."); // add item to combo box
        }

        private void clear()
        {

            //Clear the fields

            cmbApartType.Items.Clear();
            txtSearchdetails.Text = "SEARCH DATA TO EDIT";
            loadApartTypes();
            cmbApartNa.Items.Clear();
            txtApartmentID.Text = "";
            txtApartLocation.Text = "";
            txtSecID.Text = "";
            cmbTitle.Text = "";
            loadTitle();
            txtNoofUnits.Text = "";
            txtSecFn.Text = "";
            txtSecLn.Text = "";
            txtNIC.Text = "";
            txtContact.Text = "";
            txtSecCompany.Text = "";
            txtCompanyTel.Text = "";
            dtDutyOffTime.ResetText();
            dtDutyOnTime.ResetText();
            dtDutyOn.ResetText();
            dtDutyOff.ResetText();
        

            btnSearch.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnPay.Enabled = true;


        }


        private void cmbApartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtApartmentID.Text = "";
                txtApartLocation.Text = "";
                txtNoofUnits.Text = "";
                

               
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
                string sql = "SELECT apart_id,apart_location,apart_levels,apart_residentialunits,apart_unitAvailaStatus FROM tbl_addApartments WHERE apart_name ='" + cmbApartNa.Text + "'";
                SqlDataReader dr = new SqlCommand(sql, con).ExecuteReader();
                while (dr.Read())
                {
                    txtApartmentID.Text = (dr["apart_id"].ToString());
                    txtApartLocation.Text = (dr["apart_location"].ToString());
                    txtNoofUnits.Text = (dr["apart_residentialunits"].ToString());


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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnPay.Enabled = false;
            
            string SearchText = txtSearchdetails.Text;
            if (SearchText == "" || SearchText == "SEARCH DATA TO EDIT")
            {
                MessageBox.Show("Enter an Valid Security ID to Search", "Invalid Search Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
                return;
            }
            try
            {
                btnPay.Enabled = false;

                Security searchSec = new Security();
                int result = searchSec.searchSecurity(txtSearchdetails.Text);
                if (result == 1)
                {
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = true;




                    cmbApartType.Text = searchSec.Aparttype;
                    cmbApartNa.Text = searchSec.Apartname;
                    txtApartmentID.Text = searchSec.Apartid;
                    txtApartLocation.Text = searchSec.Apartlocation;
                    txtNoofUnits.Text = searchSec.Apartresidentunit.ToString();


                    txtSecID.Text = searchSec.Secid;
                    cmbTitle.Text = searchSec.Sectitle;
                    txtSecFn.Text = searchSec.Secfname;
                    txtSecLn.Text = searchSec.Seclname;
                    txtNIC.Text = searchSec.Secnic;
                    txtContact.Text = searchSec.Seccontact;
                    txtSecCompany.Text = searchSec.Seccompany;
                    txtCompanyTel.Text = searchSec.Seccompanycontact;
                    dtDutyOffTime.Text = searchSec.DutyOffTime.ToString();
                    dtDutyOnTime.Text = searchSec.DutyonTime.ToString();
                    dtDutyOn.Text = searchSec.DutyonDate.ToString();
                    dtDutyOff.Text = searchSec.DutyOffDate.ToString();



                    txtSearchdetails.Text = "SEARCH DATA TO EDIT";

                }
                else if (result == 0)
                {
                    MessageBox.Show("Enter an Valid Security ID to Search", "Invalid Search Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "INVALID TRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void insertAddResHistory()
        {
            try
            {
                con.Open();
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + " Security : " + txtSecID.Text + " is Successfully Inserted" + "', '" + DateTime.Now.ToString() + "', '" + "Clerk" + "')";
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
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + "Seurity : " + txtSecID.Text + " is Successfully Updated" + "', '" + DateTime.Now.ToString() + "', '" + "Clerk" + "')";
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
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + " Security : " + txtSecID.Text + " is Successfully Deleted" + "', '" + DateTime.Now.ToString() + "', '" + "Clerk" + "')";
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

        private void btnPay_Click(object sender, EventArgs e)
        {


            if (cmbApartType.Text == "" || cmbApartNa.Text == "" || txtApartmentID.Text == "" || txtApartLocation.Text == "" || txtNoofUnits.Text == "")
            {
                MessageBox.Show("Select Apartment Details before inserting", "INVALID TRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtSecID.Text, @"^[a-zA-Z0-9\/\-\.\s]*$").Success || txtSecID.Text == "")
            {
                MessageBox.Show("Enter an Valid Resident Name ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(cmbTitle.Text, @"^[a-zA-Z\.\s]*$").Success || cmbTitle.Text == "" || cmbTitle.Text == "Select Title")
            {
                MessageBox.Show("Select a Valid Title", "INVALID SELECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtSecFn.Text, @"^[a-zA-Z\.\s]*$").Success || txtSecFn.Text == "")
            {
                MessageBox.Show("Enter a First Name Eg:- Kamal, Piyal ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtSecLn.Text, @"^[a-zA-Z\.\s]*$").Success || txtSecLn.Text == "")
            {
                MessageBox.Show("Enter valid Last Name Eg:- Jayasooriya, Dissanayaka ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtNIC.Text, @"^[a-zA-Z0-9]*$").Success || txtNIC.Text == "")
            {
                MessageBox.Show("Enter valid Number of Rooms (Eg:- 9833500127V / 199833500127) ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtContact.Text,  @"^\d{3}-?\d{3}\d{4}$").Success || txtContact.Text == "")
            {
                MessageBox.Show("Enter valid Contact Number (Eg:- 077-8621633, 0778621633 ) ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtSecCompany.Text, @"^[a-zA-Z0-9\/\-\.\s]*$").Success || txtSecCompany.Text == "")
            {
                MessageBox.Show("Enter a Valid Security Company Name ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtCompanyTel.Text,  @"^\d{3}-?\d{3}\d{4}$").Success || txtCompanyTel.Text == "")
            {
                MessageBox.Show("a Valid Security Company Contact Nuber (Eg:- 081-8621633, 0118621633 ) ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (dtDutyOff.Value <= dtDutyOn.Value )
            {
                MessageBox.Show("Select a Foward date for Duty Off Date ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

 
            Security sec = new Security();


                  sec.Apartid =txtApartmentID.Text;
                  sec.Secid = txtSecID.Text;
                  sec.Sectitle = cmbTitle.Text;
                  sec.Secfname= txtSecFn.Text;
                  sec.Seclname = txtSecLn.Text;
                  sec.Secnic = txtNIC.Text;
                  sec.Seccontact = txtContact.Text;
                  sec.Seccompany = txtSecCompany.Text;
                  sec.Seccompanycontact = txtCompanyTel.Text;
    
                  sec.DutyonDate = DateTime.Parse(dtDutyOn.Text );

                  sec.DutyOffDate = DateTime.Parse(dtDutyOff.Text);

                  DateTime dt = dtDutyOnTime.Value;
                  TimeSpan st = new TimeSpan (dt.Hour, dt.Minute, dt.Second);

                  sec.DutyonTime = st;

                  DateTime dt2 = dtDutyOffTime.Value;
                  TimeSpan st2 = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

                  sec.DutyOffTime = st2;


          try
            {
               int result = sec.insertSecurity();

                if (result == 1)
                {

                  MessageBox.Show("Secuirty : " + sec.Secid+ " Successfully Inserted", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                    insertAddResHistory();
                    clear();
                }
                else
                {
                    MessageBox.Show("Security Details Insertion is Unsuccessfull", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {

               
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbApartType.Text == "" || cmbApartNa.Text == "" || txtApartmentID.Text == "" || txtApartLocation.Text == "" || txtNoofUnits.Text == "")
            {
                MessageBox.Show("Select Apartment Details before inserting", "INVALID TRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtSecID.Text, @"^[a-zA-Z0-9\/\-\.\s]*$").Success || txtSecID.Text == "")
            {
                MessageBox.Show("Enter an Valid Resident Name ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(cmbTitle.Text, @"^[a-zA-Z\.\s]*$").Success || cmbTitle.Text == "" || cmbTitle.Text == "Select Title")
            {
                MessageBox.Show("Select a Valid Title", "INVALID SELECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtSecFn.Text, @"^[a-zA-Z\.\s]*$").Success || txtSecFn.Text == "")
            {
                MessageBox.Show("Enter a First Name Eg:- Kamal, Piyal ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtSecLn.Text, @"^[a-zA-Z\.\s]*$").Success || txtSecLn.Text == "")
            {
                MessageBox.Show("Enter valid Last Name Eg:- Jayasooriya, Dissanayaka ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtNIC.Text, @"^[a-zA-Z0-9]*$").Success || txtNIC.Text == "")
            {
                MessageBox.Show("Enter valid Number of Rooms (Eg:- 9833500127V / 199833500127) ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtContact.Text, @"^\d{3}-?\d{3}\d{4}$").Success || txtContact.Text == "")
            {
                MessageBox.Show("Enter valid Contact Number (Eg:- 077-8621633, 0778621633 ) ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtSecCompany.Text, @"^[a-zA-Z0-9\/\-\.\s]*$").Success || txtSecCompany.Text == "")
            {
                MessageBox.Show("Enter a Valid Security Company Name ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtCompanyTel.Text, @"^\d{3}-?\d{3}\d{4}$").Success || txtCompanyTel.Text == "")
            {
                MessageBox.Show("a Valid Security Company Contact Nuber (Eg:- 081-8621633, 0118621633 ) ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (dtDutyOff.Value <= dtDutyOn.Value)
            {
                MessageBox.Show("Select a Foward date for Duty Off Date ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sid = txtSecID.Text;
            res = MessageBox.Show("Do  you want to update " + sid + "?", "UPDATE RECORDS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                   
                    Security secup = new Security();

                    secup.Apartid = txtApartmentID.Text;
                    secup.Secid = txtSecID.Text;
                    secup.Sectitle = cmbTitle.Text;
                    secup.Secfname = txtSecFn.Text;
                    secup.Seclname = txtSecLn.Text;
                    secup.Secnic = txtNIC.Text;
                    secup.Seccontact = txtContact.Text;
                    secup.Seccompany = txtSecCompany.Text;
                    secup.Seccompanycontact = txtCompanyTel.Text;

                    secup.DutyonDate = DateTime.Parse(dtDutyOn.Text);
                    secup.DutyOffDate = DateTime.Parse(dtDutyOff.Text);

                    DateTime dt = dtDutyOnTime.Value;
                    TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

                    secup.DutyonTime = st;

                    DateTime dt2 = dtDutyOffTime.Value;
                    TimeSpan st2 = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

                    secup.DutyOffTime = st2;



                    int result = secup.updateSecurity();
                    if (result == 1)
                    {

                        MessageBox.Show("Security :" + txtSecID.Text + " updated Successfully", "UPDATE SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string sid = txtSecID.Text;
            res = MessageBox.Show("Do you want to Delete Security " + sid + "?", "DELETE RECORD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    Security delsec = new Security();
                    int result = delsec.deleteSecurity(sid);
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
