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
using Microsoft.Reporting.WinForms;


namespace Apartment_Management_System
{
    public partial class frmPayment : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand com;
        SqlDataReader dreader;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        string sql;
        int quantity;
        ReportDataSource rds;
        ReportParameterCollection repParams;
        DialogResult res;

   
        public frmPayment()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);

           

            Payment inv = new Payment();
            lblInvID.Text = inv.getInvId();
           

        }



        private void frmPayment_Load(object sender, EventArgs e)
        {

            cmbApartType.Text = "Select Apartment Type";

            cmbApartType.Items.Add("Luxury"); // add item to combo box

            cmbApartType.Items.Add("Semi Luxury"); // add item to combo box

            cmbApartType.Items.Add("Economy"); // add item to combo box

            cmbApartNa.Text = "Select Apartment Name";

       
   
            lblownNa.Hide();
            lblOwnID.Hide();


            cmbTitle.Text = "Select Title";
            cmbTitle.Items.Add("Mr."); // add item to combo box
            cmbTitle.Items.Add("Mrs."); // add item to combo box
            cmbTitle.Items.Add("Miss."); // add item to combo box
            cmbTitle.Items.Add("Master."); // add item to combo box
            cmbTitle.Items.Add("Rev."); // add item to combo box
            cmbTitle.Items.Add("Dr."); // add item to combo box



            cmbPayCat.Text = "Select Payment Category";
           
        



            cmbPayMethod.Text = "Select Payment Method";
            cmbPayMethod.Items.Add("Cash"); // add item to combo box
            cmbPayMethod.Items.Add("Credit/Debit Card"); // add item to combo box

            lblcredit.Hide();
            panelCreditDetails.Hide();

            btnPay.Show();
            btnCancel.Show();
            btnUpdate.Show();
            btnDelete.Show();

        }

        private void cmbPayMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPayMethod.Text == "Credit/Debit Card")
            {
                lblcredit.Show();
                panelCreditDetails.Show();
               

                return;


            }
            else if (cmbPayMethod.Text == "Cash")
            {
                lblcredit.Hide();
                panelCreditDetails.Hide();
            
                return;

            }



          
        }

        private void clear()
        {
            Payment inv = new Payment();
            lblInvID.Text = inv.getInvId();

            Payment onr = new Payment();
            lblOwnID.Text = onr.getOwnId();

            cmbTitle.Text = "Select Title";
            txtCustFn.Text = "";
            txtCustLn.Text = "";
            txtemail.Text = "";
            txtNic.Text = "";
            txtMobile.Text = "";
            cmbPayCat.Text = "Select Payment Category";
            cmbPayMethod.Text = "Select Payment Method";
            txtpayamt.Text = "0.00";
            lbltotal.Text = "0.00";
            txtResiID.Text = "";
            cmbResiNa.Text = "";
            txtResidentBlock.Text = "";
            txtResidentStatus.Text = "";
            txtPurchasePrice.Text = "";
            lblbalanceamt.Text = "0.00";
            cmbApartType.Text = "";
            cmbApartNa.Text = "";
            txtApartmentID.Text = "";
            txtApartmentID.Text = "";


            btnPay.Enabled = true;
            btnCancel.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;


        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if( cmbApartType.Text=="" || cmbApartNa.Text=="" || txtApartmentID.Text=="" || txtApartLocation.Text=="")
            {
                MessageBox.Show("Should Select an Apartment to Proceed ", "INVALID TRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.Match(cmbTitle.Text, @"^[a-zA-Z\.]*$").Success || cmbTitle.Text == "" || cmbTitle.Text == "Select Title")
            {
                MessageBox.Show("Resident Field is Empty, Search Available Resident Data ", "INVALID TRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtCustFn.Text, "^[a-zA-Z]*$").Success || txtCustFn.Text == "")
            {
                MessageBox.Show("Enter a Valid First Name (Only Letters)", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtCustLn.Text, "^[a-zA-Z]*$").Success || txtCustLn.Text == "")
            {
                MessageBox.Show("Enter a Valid Last Name (Only Letters)", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtemail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success || txtemail.Text == "")
            {
                MessageBox.Show("Enter Email in Correct Format (Eg:- admin@abc.lk, isuru.udara@abc.com )", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtNic.Text, "^[0-9A-Z]*$").Success || txtNic.Text == "")
            {
                MessageBox.Show("Enter a Valid NIC Number (Eg:- 9833500127V / 199833500127)", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtMobile.Text, @"^\d{3}-?\d{3}\d{4}$").Success || txtMobile.Text == "")
            {
                MessageBox.Show("Enter a Valid Phone Number (Eg:- 077-8621633, 0778621633 )", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtResiID.Text=="")
            {
                MessageBox.Show("Resident Should be Selected )", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbPayCat.Text == "Select Payment Category")
            {
                MessageBox.Show("Select a Payment Category", "INVALID SELECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (cmbPayMethod.Text == "Select Payment Method" || cmbPayMethod.Text == "")
            {
                MessageBox.Show("Select a Select Payment Method", "INVALID SELECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtpayamt.Text == "0.00")
            {
                MessageBox.Show("Enter Paying Amount", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            Payment pay = new Payment();

            DateTime today = DateTime.Today;

            pay.CusRegdate = today;

            pay.Invid = lblInvID.Text;

            pay.OwnTenMainid = lblOwnID.Text;
            pay.Apartid = txtApartmentID.Text;
          
            pay.Resid = txtResiID.Text;    
           
            pay.Custitle = cmbTitle.Text;
            pay.CusFname = txtCustFn.Text;
            pay.CusLname = txtCustLn.Text;
            pay.Cusnic = txtNic.Text;
            pay.Cuscontact = txtMobile.Text;
            pay.Cusemail = txtemail.Text;
            pay.Paycat = cmbPayCat.Text;
            pay.Paymethod = cmbPayMethod.Text;

            pay.Totamt = float.Parse(lbltotal.Text);
            pay.Payamt =  float.Parse(txtpayamt.Text);
            pay.Balamt =  float.Parse(lblbalanceamt.Text);

         if(rdoNewCus.Checked==true)
         {
             pay.Cusservice = "Purchase";
         }
         else if (rdoRentalNewCus.Checked==true)
         {
             pay.Cusservice = "Rental";
         }



            try
            {
                // pass parameters to invoice report
                ReportParameterCollection repParams = new ReportParameterCollection();

                frmInvoicerpt frmp = new frmInvoicerpt();


                repParams.Add(new ReportParameter("parmInvoiceID", lblInvID.Text));
                repParams.Add(new ReportParameter("paramCusTitle", cmbTitle.Text));
                repParams.Add(new ReportParameter("paramCusLn", txtCustFn.Text));
                repParams.Add(new ReportParameter("paramCusFn", txtCustLn.Text));

                repParams.Add(new ReportParameter("paramCusNic", txtNic.Text));
                repParams.Add(new ReportParameter("paramCusContact", txtMobile.Text));
                repParams.Add(new ReportParameter("paramEmail", txtemail.Text));
                repParams.Add(new ReportParameter("paramResID",txtResiID.Text));
                repParams.Add(new ReportParameter("paramApartTyp",cmbApartType.Text));
                repParams.Add(new ReportParameter("paramResName", cmbResiNa.Text));
                repParams.Add(new ReportParameter("paramApartLoc", txtApartLocation.Text));
               
                

                if (rdoNewCus.Checked==true)
                {
                    lblsertyp.Text = "Resident Purchase";
                }
                else if(rdoRentalNewCus.Checked==true)
                {
                    lblsertyp.Text = "Resident Rental";
                }




                repParams.Add(new ReportParameter("paramSerTyp", lblsertyp.Text));
                repParams.Add(new ReportParameter("paramPayCat", cmbPayCat.Text));
                repParams.Add(new ReportParameter("paramPaymethod", cmbPayMethod.Text));
                repParams.Add(new ReportParameter("paramPurPrice", txtPurchasePrice.Text));

                repParams.Add(new ReportParameter("paramTotal", lbltotal.Text));
                repParams.Add(new ReportParameter("paramPayamt", txtpayamt.Text));
                repParams.Add(new ReportParameter("paramBalance", lblbalanceamt.Text));

                frmp.reportViewer1.LocalReport.SetParameters(repParams);
                frmp.reportViewer1.RefreshReport();


                int result = pay.insertInvoice();

                if (rdoNewCus.Checked==true)
                {
                    updateRes(); // ADD OWNER DATA TO TABLE
                    pay.insertOwner();
                    frmp.ShowDialog(); //DISPLAYS INVOICE REPORT FOR OWNER

                    
                }
                else if (rdoRentalNewCus.Checked==true)
                {
                    updateResiTenant(); // ADD TENANT DATA TO TABLE
                    pay.insertTenant();
                    frmp.ShowDialog(); //DISPLAYS INVOICE REPORT FOR TENANT
                }
                

                if (result == 1)
                {

                    MessageBox.Show("Invoice : " + pay.Invid + " Successfully Inserted", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Open(); 
                    string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + "Invoice : " + pay.Invid + " and " + pay.OwnTenMainid + "  Owner / Tenant Data, Successfully Inserted" + "', '" + DateTime.Now.ToString() + "', '" + "Cashier" + "')";
                    com = new SqlCommand(sql, con);
                    com.ExecuteNonQuery();
                    clear(); //  CLEAR THE TEXT BOXES
                }
                else
                {
                    MessageBox.Show("Invoice Creation is Unsuccessfull", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();

               
                Payment inv = new Payment();
                lblInvID.Text = inv.getInvId();

                Payment onr = new Payment();
                lblOwnID.Text = onr.getOwnId();
                
            }

        }



        private void updateRes()
        {
            try
            {
                con.Open();
                // UPDATE Query

                string resstatus = "Sold";

                string resiID = txtResiID.Text;

                string sql = "UPDATE tbl_addResidents SET res_Status = '" + resstatus + "' WHERE res_unitID= '" + resiID + "'";
                SqlCommand com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();





            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Try", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);


            }
            finally
            {
                con.Close();

            }
        }


        private void updateResiTenant()
        {
            try
            {
                con.Open();
                // UPDATE Query

                string resstatus = "Rented";

                string resiID = txtResiID.Text;

                string sql = "UPDATE tbl_addResidents SET res_Status = '" + resstatus + "' WHERE res_unitID= '" + resiID + "'";
                SqlCommand com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();

                
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Try", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);


            }
            finally
            {
                con.Close();

            }
        }











        private void rdoRentalNewCus_CheckedChanged(object sender, EventArgs e)
        {
            
            
            
    

            lblSearchRes.Show();
            PanelRes.Show();

           

            if (rdoRentalNewCus.Checked == true)
            {
                cmbPayCat.Items.Add("Rental KeyMoney"); // add item to combo box
                
                lblownNa.Show();
                lblOwnID.Show();

                lblownNa.Text="Tenant ID #";

                Payment tena = new Payment();

                lblOwnID.Text = tena.getTenId();

            }
           
           
            if (rdoNewCus.Checked == true)
            {
                cmbPayCat.Items.Remove("Rental KeyMoney"); // add item to combo box
                

            }
        }

        private void rdoNewCus_CheckedChanged(object sender, EventArgs e)
        {
                 
 

            lblSearchRes.Show();
            PanelRes.Show();

          

            if (rdoNewCus.Checked==true)
            {
                cmbPayCat.Items.Add("Full Payment"); // add item to combo box
                cmbPayCat.Items.Add("Down Payment"); // add item to combo box

                lblownNa.Show();
                lblownNa.Text = "Owner ID #";
                lblOwnID.Show();
            
                Payment onr = new Payment();
                lblOwnID.Text = onr.getOwnId();
                
            }
           
            else if (rdoRentalNewCus.Checked == true)
            {
                cmbPayCat.Items.Remove("Full Payment");
                cmbPayCat.Items.Remove("Down Payment");
                lblownNa.Hide();
                lblOwnID.Hide();
               
            }
        }



       
        private void btnClear_Click(object sender, EventArgs e)
        {
            res = MessageBox.Show("Do  you want Clear All the Fields", "CLEAR RECORDS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                txtResiID.Text = "";
                cmbResiNa.Text = "";
                txtResidentBlock.Text = "";
                txtPurchasePrice.Text = "";
                txtResidentStatus.Text = "";
            }
            else if (res == DialogResult.No) // WARNING BEFORE CLEARING
            {
                return;
            }
        }

        private void txtpayamt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal total = decimal.Parse(lbltotal.Text);


                decimal payamt = decimal.Parse(txtpayamt.Text);

               

                // Caluculate the Final Total

                decimal balance = total - payamt;

                //display the final tota in text box

                lblbalanceamt.Text = balance.ToString();

            }
            catch(Exception )
            {
                MessageBox.Show("Pay Amount can Only have Numbers eg:- 450000/ 450000.00","Parse Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }


        }

        private void btnsearchdetails_Click(object sender, EventArgs e)
        {
            string SearchText = txtSearchdetails.Text;
            if (SearchText == "" || SearchText == "Enter Invoice ID to Search")
            {
                MessageBox.Show("Enter RES ID No to Search", "Invalid Search Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
                return;
            }
            try
            {
                btnPay.Enabled = false;
                Payment invsearch = new Payment();
                int result = invsearch.searchInvoice(txtSearchdetails.Text);
                if (result == 1)
                {

                    btnCancel.Enabled = true;


                    lblInvID.Text = invsearch.Invid;

                    lblOwnID.Text = invsearch.OwnTenMainid;

                    cmbTitle.Text = invsearch.Custitle;

                    txtCustFn.Text=invsearch.CusFname;
                    txtCustLn.Text = invsearch.CusLname;
                    txtNic.Text=invsearch.Cusnic;
                    txtMobile.Text = invsearch.Cuscontact;
                    txtemail.Text= invsearch.Cusemail;

                    cmbPayCat.Text = invsearch.Paycat;

                    if (invsearch.Cusservice == "Rental")
                    {
                        rdoRentalNewCus.Checked = true;
                    }
                    else if (invsearch.Cusservice == "Purchase")
                    {
                        rdoNewCus.Checked = true;
                    }
                    cmbPayMethod.Text = invsearch.Paymethod;
                    lbltotal.Text = invsearch.Totamt.ToString();
                    txtpayamt.Text = invsearch.Payamt.ToString();
                    lblbalanceamt.Text = invsearch.Balamt.ToString();



                    txtResiID.Text = invsearch.Resid;
                    cmbResiNa.Text = invsearch.Resname;
                    txtResidentBlock.Text = invsearch.Resblock;
                    if (rdoNewCus.Checked == true)
                    {
                        txtPurchasePrice.Text = invsearch.Purprice;
                    }
                    else if(rdoRentalNewCus.Checked == true)
                    {
                        txtPurchasePrice.Text = invsearch.Rentprice;
                    }
                    
                    txtResidentStatus.Text = invsearch.Resstatus;
                    txtNoofRoom.Text = invsearch.Resroom.ToString(); ;
                    txtNoofBath.Text = invsearch.Resbathroom.ToString(); ;

                    cmbApartType.Text = invsearch.Aparttype;
                    cmbApartNa.Text = invsearch.Apartname;
                    txtApartmentID.Text=invsearch.Apartid;
                    txtApartLocation.Text = invsearch.Apartlocation;


                    txtSearchdetails.Text = "Enter Invoice ID to Search";

                }
                else if (result == 0)
                {
                    MessageBox.Show("Invalid Invoice ID", "Invalid Search Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
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
                                      
            catch(Exception ex)
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
                    string sql = "SELECT res_name FROM tbl_addResidents WHERE apart_id ='" + txtApartmentID.Text + "' AND res_Status = 'Available'";
                    SqlDataReader dr = new SqlCommand(sql, con).ExecuteReader();
                    if (dr.HasRows==true)
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

                    if(rdoNewCus.Checked==true)
                    {
                        txtPurchasePrice.Text = (dr["res_price"].ToString());
                        lbltotal.Text = (dr["res_price"].ToString());
                    }
                    else if(rdoRentalNewCus.Checked==true)
                    {
                        txtPurchasePrice.Text = (dr["res_rentAmt"].ToString());
                        lbltotal.Text = (dr["res_rentAmt"].ToString());
                    }

                    txtResidentStatus.Text = (dr["res_Status"].ToString());

                    txtNoofRoom.Text = (dr["res_noOfRooms"].ToString());

                    txtNoofBath.Text = (dr["res_noOfBathRooms"].ToString());

                    

                    
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

        private void txtResiID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void txtResidentBlock_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            res = MessageBox.Show("Do  you want Clear All the Fields", "CLEAR FIELDS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                clear();
            }
            else if (res == DialogResult.No)
            {
                return;
            }
        }





        public void insertUpInvHistory() // Insert log Task When a record is updated
        {
            try
            {
                con.Open();
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + "Invoice : " + lblInvID.Text + " is Successfully Updated" + "', '" + DateTime.Now.ToString() + "', '" + "Cashier" + "')";
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


        public void insertDelInvHistory() // Insert log Task When a record is updated
        {
            try
            {
                con.Open();
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + " Invoice : " + lblInvID.Text + " is Successfully Deleted" + "', '" + DateTime.Now.ToString() + "', '" + "Cashier" + "')";
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
            string inid = lblInvID.Text;
            res = MessageBox.Show("Do  you want to Update :  " + lblInvID.Text + " ", "UPDATE RECORD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    Payment pay = new Payment();


                    pay.Invid = lblInvID.Text;

                    pay.OwnTenMainid = lblOwnID.Text;
                    pay.Apartid = txtApartmentID.Text;

                    pay.Resid = txtResiID.Text;

                    pay.Custitle = cmbTitle.Text;
                    pay.CusFname = txtCustFn.Text;
                    pay.CusLname = txtCustLn.Text;
                    pay.Cusnic = txtNic.Text;
                    pay.Cuscontact = txtMobile.Text;
                    pay.Cusemail = txtemail.Text;
                    pay.Paycat = cmbPayCat.Text;
                    pay.Paymethod = cmbPayMethod.Text;

                    pay.Totamt = float.Parse(lbltotal.Text);
                    pay.Payamt = float.Parse(txtpayamt.Text);
                    pay.Balamt = float.Parse(lblbalanceamt.Text);

                    if (rdoNewCus.Checked == true)
                    {
                        pay.Cusservice = "Purchase";
                    }
                    else if (rdoRentalNewCus.Checked == true)
                    {
                        pay.Cusservice = "Rental";
                    }






                    int result = pay.updateInvoice();
                    if (result == 1)
                    {

                        MessageBox.Show("Invoice :" + lblInvID.Text + " updated Successfully", "UPDATE SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        insertUpInvHistory();
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
            string inid = lblInvID.Text;

            res = MessageBox.Show("Do  you want to Delete :  " + lblInvID.Text + " ", "UPDATE RECORD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    Payment pay = new Payment();
                    int result = pay.deleteInvoice(inid);
                    if (result == 1)
                    {
                        MessageBox.Show("Record Deleted Successfully", "DELETE SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        insertDelInvHistory();
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



  
