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
    public partial class frmCreateAccount : Form
    {
        DialogResult res;
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand com;
        DataTable dt;
        public frmCreateAccount()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);

            Employee emp = new Employee();
            lblEMPId.Text = emp.getEmpId();

            picCorrect.Hide();
            picCorrect2.Hide();
            picWrong.Hide();
            picWrong2.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            this.dt1.Value = DateTime.Now;

            
            
            cmbTitle.Text = "Select Title";
            cmbTitle.Items.Add("Mr."); // add item to combo box
            cmbTitle.Items.Add("Mrs."); // add item to combo box
            cmbTitle.Items.Add("Miss."); // add item to combo box
            cmbTitle.Items.Add("Master."); // add item to combo box
            cmbTitle.Items.Add("Rev."); // add item to combo box
            cmbTitle.Items.Add("Dr."); // add item to combo box


            cmbState.Text = "Select State";
            cmbState.Items.Add("Northern"); // add item to combo box
            cmbState.Items.Add("North Central"); // add item to combo box
            cmbState.Items.Add("North Western"); // add item to combo box
            cmbState.Items.Add("Central"); // add item to combo box
            cmbState.Items.Add("North Western"); // add item to combo box
            cmbState.Items.Add("Western"); // add item to combo box
            cmbState.Items.Add("Sabaragamuwa"); // add item to combo box
            cmbState.Items.Add("Uva"); // add item to combo box
            cmbState.Items.Add("Eastern"); // add item to combo box
            cmbState.Items.Add("Southern"); // add item to combo box


            cmbUserType.Text = "Select User Type";
            cmbUserType.Items.Add("Manager"); // add item to combo box
            cmbUserType.Items.Add("Clerk"); // add item to combo box
            cmbUserType.Items.Add("Cashier"); // add item to combo box


            cmbStatus.Text = "Select User Status";
            cmbStatus.Items.Add("Active"); // add item to combo box
            cmbStatus.Items.Add("Disabled"); // add item to combo box


   
        }
        private void clear()
        {
            Employee emp = new Employee();
            lblEMPId.Text = emp.getEmpId();
            cmbTitle.Text = "Select Title";
            txtEMPFn.Text = "";
            txtEmail.Text = "";
            txtEMPLn.Text = "";
            txtNIC.Text="";
            txtContact.Text = "";
            txtNo.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            cmbState.Text = "Select State";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            cmbUserType.Text = "Select User Type";
            cmbStatus.Text = "Select User Status";
            picSearch.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnCreateAcc.Enabled = true;
            
           
        }
        private void txtPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void txtConfirmPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                btnShowPass.BringToFront();
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                btnHidePass.BringToFront();
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == false)
            {
                btnHidePass.BringToFront();
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                btnShowPass.BringToFront();
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnHidepass2_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.UseSystemPasswordChar == true)
            {
                btnShowPass2.BringToFront();
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                btnHidepass2.BringToFront();
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnShowPass2_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.UseSystemPasswordChar == false)
            {
                btnHidepass2.BringToFront();
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
            else
            {
                btnShowPass2.BringToFront();
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
        }

        private void picSearch_Click(object sender, EventArgs e)
        {

            string SearchText=txtSearchdetails.Text;//Declare Variable
            if (SearchText== "" || SearchText == "ENTER EMP NO / NIC TO SEARCH")
            {
                MessageBox.Show("Enter EMP No / NIC No to Search", "Invalid Search Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
                return;
            }
            try
            {
                btnCreateAcc.Enabled = false;
                Employee emp = new Employee();//Call EMPLOYEE Object
                int result = emp.searchEmployee(txtSearchdetails.Text);
                if (result == 1)
                {
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = true;

                    dt1.Text = emp.EmpRegdate.ToString();
                    lblEMPId.Text = emp.Empid;
                    cmbTitle.Text = emp.Emptitle;
                    txtEMPFn.Text= emp.EmpFname;
                    txtEMPLn.Text = emp.EmpLname;
                    txtNIC.Text = emp.Empnic;
                    txtContact.Text = emp.Empcontact;
                    txtNo.Text = emp.Empaddno;
                    txtStreet.Text = emp.Empaddstreet;
                    txtCity.Text = emp.Empaddcity;
                    cmbState.Text= emp.Empaddstate;
                    
                    txtEmail.Text= emp.Empemail;
                    txtUserName.Enabled = false;
                    txtPassword.Enabled = false;
                    txtConfirmPassword.Enabled = false;
                    cmbUserType.Text=emp.Emptype;
                    cmbStatus.Text = emp.Empstatus;

                    txtSearchdetails.Text = "ENTER EMP NO / NIC TO SEARCH";
                    
                }
                else if (result == 0)
                {
                    MessageBox.Show("Invalid Employee ID","Invalid Search Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            
        }


        public void insertAddEmpHistory()
        {
            try
            {
                con.Open();
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + "Employee : " + lblEMPId.Text + " is Successfully Inserted" + "', '" + DateTime.Now.ToString() + "', '" + "Admin" + "')";
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



        public void insertUpEmpHistory() // Insert log Task When a record is updated
        {
            try
            {
                con.Open();
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + "Employee : " + lblEMPId.Text + " is Successfully Updated" + "', '" + DateTime.Now.ToString() + "', '" + "Admin" + "')";
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



        public void insertDelEmpHistory() // Insert log Task When a record is updated
        {
            try
            {
                con.Open();
                string sql = "INSERT INTO tbl_systemtaskHistory (task_description,date_time,emp_id) VALUES ('" + " Employee : " + lblEMPId.Text + " is Successfully Deleted" + "', '" + DateTime.Now.ToString() + "', '" + "Admin" + "')";
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









        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            if (!Regex.Match(cmbTitle.Text, @"^[a-zA-Z\.]*$").Success || cmbTitle.Text == "" || cmbTitle.Text == "Select Title")
            {
                MessageBox.Show("Title Can Only have Selected Items", "INVALID SELECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtEMPFn.Text, "^[a-zA-Z]*$").Success || txtEMPFn.Text == "")
            {
                MessageBox.Show("Enter a Valid First Name (Only Letters)", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtEMPLn.Text, "^[a-zA-Z]*$").Success || txtEMPLn.Text == "")
            {
                MessageBox.Show("Enter a Valid Last Name (Only Letters)", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success || txtEmail.Text == "")
            {
                MessageBox.Show("Enter Email in Correct Format (Eg:- admin@abc.lk, isuru.udara@abc.com )", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtNIC.Text, "^[0-9A-Z]*$").Success || txtNIC.Text == "")
            {
                MessageBox.Show("Enter a Valid NIC Number (Eg:- 9833500127V / 199833500127)", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtContact.Text, @"^\d{3}-?\d{3}\d{4}$").Success || txtContact.Text == "")
            {
                MessageBox.Show("Enter a Valid Phone Number (Eg:- 077-8621633, 0778621633 )", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtNo.Text, @"^[0-9a-zA-Z\/\,\-\s]*$").Success || txtNo.Text == "")
            {
                MessageBox.Show("Enter a Valid House No (Eg:- 78/A, 8/26T, 45/1)", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtStreet.Text, @"^[0-9a-zA-Z\/\,\-\s]*$").Success || txtStreet.Text == "")
            {
                MessageBox.Show("Enter a Valid Street Name (Eg:- 4th, Lane , Peradeniya Road, )", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtCity.Text, @"^[a-zA-Z\/\,\-\s]*$").Success || txtCity.Text == "")
            {
                MessageBox.Show("Enter a Valid City Name (Eg:- Kandy , Gampola )", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(cmbState.Text, @"^[a-zA-Z\s]*$").Success || cmbState.Text == "" || cmbState.Text == "Select State")
            {
                MessageBox.Show("Select a Valid State (Eg:- Central , Western )", "INVALID SELECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            else if (!Regex.Match(txtUserName.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success || txtUserName.Text == "")
            {
                MessageBox.Show("Enter a Valid UserName", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,50}$").Success || txtPassword.Text == "")
            {
                MessageBox.Show("Enter a Valid Password,(Password Should Contain characters Minimum 8 - Maximum 50, at least one number,  at least one uppercase letter and lowercase letter,  at least one special Character)", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(cmbUserType.Text, @"^[a-zA-Z\s]*$").Success || cmbUserType.Text == "" || cmbUserType.Text == "Select User Type")
            {
                MessageBox.Show("User Type Can Only have Selected Items", "INVALID SELECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(cmbStatus.Text, @"^[a-zA-Z\s]*$").Success || cmbStatus.Text == "" || cmbStatus.Text == "Select User Status")
            {
                MessageBox.Show("User Status Can Only have Selected Items", "INVALID SELECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             

            Employee emp = new Employee();
            emp.EmpRegdate = DateTime.Parse(dt1.Text);
            emp.Empid = lblEMPId.Text;
            emp.Emptitle = cmbTitle.Text;
            emp.EmpFname = txtEMPFn.Text;
            emp.EmpLname = txtEMPLn.Text;
            emp.Empnic = txtNIC.Text;
            emp.Empaddno = txtNo.Text;
            emp.Empaddstreet = txtStreet.Text;
            emp.Empaddcity = txtCity.Text;
            emp.Empaddstate = cmbState.Text;
            emp.Empcontact = txtContact.Text;
            emp.Empemail = txtEmail.Text;
            emp.Empusername = txtUserName.Text;       
            emp.Emppassword = txtPassword.Text;
            emp.Emptype = cmbUserType.Text;
            emp.Empstatus = cmbStatus.Text;

            try
            {
                int result = emp.insertEmployee();

                if (result == 1)
                {
                    MessageBox.Show("Employee : " + emp.Empid + " Successfully Inserted", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    insertAddEmpHistory();
                    clear();
                }
                else
                {
                    MessageBox.Show("Employee Account Creation is Unsuccessfull", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }   
            finally
            {
                
                lblEMPId.Text = emp.getEmpId();
            }

        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            string pass = txtPassword.Text;
            string passconfrim = txtConfirmPassword.Text;
            if (pass == passconfrim)
            {
                picCorrect.Show();
                picCorrect2.Show();

                picWrong.Hide();
                picWrong2.Hide();



            }
            else if (pass != passconfrim)
            {
                picWrong.Show();
                picWrong2.Show();

                picCorrect.Hide();
                picCorrect2.Hide();

                MessageBox.Show("Both Password and Confirm Password must be Similar, Try Again ", "INVALID PASWWORD CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                


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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Regex.Match(cmbTitle.Text, @"^[a-zA-Z\.]*$").Success || cmbTitle.Text == "" || cmbTitle.Text == "Select Title")
            {
                MessageBox.Show("Title Can Only have Selected Items", "INVALID SELECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtEMPFn.Text, "^[a-zA-Z]*$").Success || txtEMPFn.Text == "")
            {
                MessageBox.Show("Enter a Valid First Name (Only Letters)", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtEMPLn.Text, "^[a-zA-Z]*$").Success || txtEMPLn.Text == "")
            {
                MessageBox.Show("Enter a Valid Last Name (Only Letters)", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success || txtEmail.Text == "")
            {
                MessageBox.Show("Enter Email in Correct Format (Eg:- admin@abc.lk, isuru.udara@abc.com )", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtNIC.Text, "^[0-9A-Z]*$").Success || txtNIC.Text == "")
            {
                MessageBox.Show("Enter a Valid NIC Number (Eg:- 9833500127V / 199833500127)", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtContact.Text, @"^\d{3}-?\d{3}\d{4}$").Success || txtContact.Text == "")
            {
                MessageBox.Show("Enter a Valid Phone Number (Eg:- 077-8621633, 0778621633 )", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtNo.Text, @"^[0-9a-zA-Z\/\,\-\s]*$").Success || txtNo.Text == "")
            {
                MessageBox.Show("Enter a Valid House No (Eg:- 78/A, 8/26T, 45/1)", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtStreet.Text, @"^[0-9a-zA-Z\/\,\-\s]*$").Success || txtStreet.Text == "")
            {
                MessageBox.Show("Enter a Valid Street Name (Eg:- 4th, Lane , Peradeniya Road, )", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(txtCity.Text, @"^[a-zA-Z\/\,\-\s]*$").Success || txtCity.Text == "")
            {
                MessageBox.Show("Enter a Valid City Name (Eg:- Kandy , Gampola )", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.Match(cmbState.Text, @"^[a-zA-Z\s]*$").Success || cmbState.Text == "" || cmbState.Text == "Select State")
            {
                MessageBox.Show("Select a Valid State (Eg:- Central , Western )", "INVALID SELECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            else if (!Regex.Match(txtUserName.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success || txtUserName.Text == "")
            {
                MessageBox.Show("Enter a Valid UserName", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(txtPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,50}$").Success || txtPassword.Text == "")
            {
                MessageBox.Show("Enter a Valid Password,(Password Should Contain characters Minimum 8 - Maximum 50, at least one number,  at least one uppercase letter and lowercase letter,  at least one special Character)", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(cmbUserType.Text, @"^[a-zA-Z\s]*$").Success || cmbUserType.Text == "" || cmbUserType.Text == "Select User Type")
            {
                MessageBox.Show("User Type Can Only have Selected Items", "INVALID SELECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.Match(cmbStatus.Text, @"^[a-zA-Z\s]*$").Success || cmbStatus.Text == "" || cmbStatus.Text == "Select User Status")
            {
                MessageBox.Show("User Status Can Only have Selected Items", "INVALID SELECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string eid = lblEMPId.Text;
            res = MessageBox.Show("Do  you want to update " + eid + "?", "UPDATE RECORDS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    Employee emp = new Employee();


                    emp.EmpRegdate = DateTime.Parse(dt1.Text);
                    emp.Empid = lblEMPId.Text;
                    emp.Emptitle = cmbTitle.Text;
                    emp.EmpFname = txtEMPFn.Text;
                    emp.EmpLname = txtEMPLn.Text;
                    emp.Empnic = txtNIC.Text;
                    emp.Empaddno = txtNo.Text;
                    emp.Empaddstreet = txtStreet.Text;
                    emp.Empaddcity = txtCity.Text;
                    emp.Empaddstate = cmbState.Text;
                    emp.Empcontact = txtContact.Text;
                    emp.Empemail = txtEmail.Text;
                    
                    emp.Emptype = cmbUserType.Text;
                    emp.Empstatus = cmbStatus.Text;

                    int result = emp.updateEmployee();
                    if (result == 1)
                    {
                        MessageBox.Show("Record updated successfully", "UPDATE SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        insertUpEmpHistory();
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
            string eid = lblEMPId.Text;
            res = MessageBox.Show("Do  you want to Delete " + eid + "?", "DELETE RECORDS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    Employee emp = new Employee();
                    int result = emp.deleteEmployee(eid);
                    if (result == 1)
                    {
                        MessageBox.Show("Record Deleted Successfully", "DELETE SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        insertDelEmpHistory();// Insert the Task to SYSTEM LOG
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
