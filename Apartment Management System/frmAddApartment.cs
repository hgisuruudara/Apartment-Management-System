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
    public partial class frmAddApartment : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand com;
        DialogResult res;
        public frmAddApartment()
        {
            InitializeComponent();

            //Database Connection
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);

            //Generate New ID
            Apartment apa = new Apartment();
            lblApaId.Text = apa.getApartId();

        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {

            if (txtApaName.Text == "")
            {
                MessageBox.Show("Enter a Valid Apartment Name", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtApaLocation.Text == "")
            {
                MessageBox.Show("Enter a Valid Location", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(cmbApartType.Text, @"^[a-zA-Z0-9\s]*$").Success || cmbApartType.Text == "Select Apartment Type" || cmbApartType.Text == "")
            {
                MessageBox.Show("Select a valid Apartment Type", "INVALID SELECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtNoLel.Text, @"^[a-zA-Z0-9\s]*$").Success || txtNoLel.Text == "")
            {
                MessageBox.Show("Enter a Valid No Level", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtResNo.Text, @"^[0-9\.\s]*$").Success || txtResNo.Text == "")
            {
                MessageBox.Show("Enter a valid No of Residential Units ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtAvaUnit.Text, @"^[0-9\.\s]*$").Success || txtAvaUnit.Text == "")
            {
                MessageBox.Show("Enter Available No of Units ", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Apartment apa = new Apartment();

            apa.Apartid = lblApaId.Text;
            apa.Apartname = txtApaName.Text;
            apa.Apartlocation = txtApaLocation.Text;
            apa.Aparttype = cmbApartType.Text;
            apa.Apartlevel = int.Parse(txtNoLel.Text);
            apa.Apartresidentunit = int.Parse(txtResNo.Text);
            apa.Apartunitstatus = int.Parse(txtAvaUnit.Text);

            

           try
            {
                int result = apa.insertApartment();

                if (result == 1)
                {
                    MessageBox.Show("Apartment : " + apa.Apartid + " Successfully Inserted", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    insertAddHistory();
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

                lblApaId.Text = apa.getApartId();
            }
        }

        public void insertAddHistory()
        {
           try
            {
                con.Open();
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + "Apartment : " + lblApaId.Text + " is Successfully Inserted" + "', '" + DateTime.Now.ToString() + "', '" + "Manager/Clerk" + "')";
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
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + " Apartment : " + lblApaId.Text + " is Successfully Updated" + "', '" + DateTime.Now.ToString() + "', '" + "Manager/Clerk" + "')";
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
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + " Apartment : " + lblApaId.Text + " is Successfully Deleted" + "', '" + DateTime.Now.ToString() + "', '" + "Manager/Clerk" + "')";
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



        private void btnSearch_Click(object sender, EventArgs e)
        {
            string SearchText = txtSearchdetails.Text;
            if (SearchText == "" || SearchText == "ENTER APA NO TO SEARCH")
            {
                MessageBox.Show("Enter an Valid Apartment ID to Search", "Invalid Search Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
                return;
            }
            try
            {
                btnCreateAcc.Enabled = false;
                Apartment apart = new Apartment();
                int result = apart.searchApartments(txtSearchdetails.Text);
                if (result == 1)
                {
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = true;



                    lblApaId.Text = apart.Apartid;
                    txtApaLocation.Text = apart.Apartlocation;
                    txtApaName.Text = apart.Apartname;
                    cmbApartType.Text = apart.Aparttype;
                    txtNoLel.Text = apart.Apartlevel.ToString();
                    txtResNo.Text = apart.Apartresidentunit.ToString();
                    txtAvaUnit.Text = apart.Apartunitstatus.ToString();

                    txtSearchdetails.Text = "ENTER APA NO TO SEARCH";

                }
                else if (result == 0)
                {
                    MessageBox.Show("Enter an Valid Apartment ID to Search", "Invalid Search Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
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

        private void clear()
        {
            Apartment apa = new Apartment();
            lblApaId.Text = apa.getApartId();
            txtSearchdetails.Text = "ENTER APA NO TO SEARCH";
            txtApaLocation.Text = "";
            txtApaName.Text = "";
            cmbApartType.Text = "";
            txtNoLel.Text = "";
            txtResNo.Text = "";
            txtAvaUnit.Text = "";
            btnSearch.Enabled = true;      
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnCreateAcc.Enabled = true;


        }

        private void frmAddApartment_Load(object sender, EventArgs e)
        {
            cmbApartType.Text = "Select Apartment Type";

            cmbApartType.Items.Add("Luxury"); // add item to combo box
            
            cmbApartType.Items.Add("Semi Luxury"); // add item to combo box

            cmbApartType.Items.Add("Economy"); // add item to combo box

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string aid = lblApaId.Text;
            res = MessageBox.Show("Do  you want to update " + aid + "?", "UPDATE RECORDS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    Apartment apa = new Apartment();

                    apa.Apartid = lblApaId.Text;
                    apa.Apartname = txtApaName.Text;
                    apa.Apartlocation = txtApaLocation.Text;
                    apa.Aparttype = cmbApartType.Text;
                    apa.Apartlevel = int.Parse(txtNoLel.Text);
                    apa.Apartresidentunit = int.Parse(txtResNo.Text);
                    apa.Apartunitstatus = int.Parse(txtAvaUnit.Text);




                    int result = apa.updateApartment();
                    if (result == 1)
                    {
                        MessageBox.Show("Record updated Successfully", "UPDATE SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string aid = lblApaId.Text;
            res = MessageBox.Show("Do  you want to Delete " + aid + "?", "DELETE RECORDS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    Apartment apa = new Apartment();
                    int result = apa.deleteApartment(aid);
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
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

    }
}
