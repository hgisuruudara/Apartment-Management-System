using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Apartment_Management_System
{
    public partial class frmLogin : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand com;
        DataTable dt;
        public string utype;
        public string ustatus;
        public frmLogin()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

      

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar==true)
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

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "    Enter  Username";
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "    Enter  Username")
            {
                txtUserName.Text = null;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "    Enter  Password";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "    Enter  Password")
            {
                txtPassword.Text = null;
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            btnHidePass.BringToFront();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = "SELECT * FROM tbl_empRegister WHERE emp_username= '" + txtUserName.Text + "' AND emp_password= '" + txtPassword.Text + "' ";
                com = new SqlCommand(sql, con);
                da = new SqlDataAdapter(com);
                dt = new DataTable();
                da.Fill(dt);
                
                    if (dt.Rows.Count > 0)
                    {
                        ustatus = dt.Rows[0][15].ToString().Trim();

                        if (ustatus == "Active")
                        {
                            utype = dt.Rows[0][14].ToString().Trim();
                            lblEmployeeID.Text = dt.Rows[0][1].ToString().Trim();

                            if (utype == "Admin")
                            {                         
                                MessageBox.Show("Logged In Successfully as Administrator", "Login Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                frmMainMenu_Admin frmAdmin = new frmMainMenu_Admin();
                                frmAdmin.Show();
                            }
                            else if (utype == "Manager")
                            {
                                MessageBox.Show("Logged In Successfully as Center Manger", "Login Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                frmMainMenu_Manager frmMange = new frmMainMenu_Manager();
                               
                                frmMange.Show();
                            }
                            else if (utype == "Clerk")
                            {
                                MessageBox.Show("Logged In Successfully as Clerk", "Login Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                frmMainMenu_Clerk frmClerk = new frmMainMenu_Clerk();
                                
                                frmClerk.Show();
                            }
                            else if (utype == "Cashier")
                            {
                                MessageBox.Show("Logged In Successfully as Cashier", "Login Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                frmMainMenu_Cashier frmCashier = new frmMainMenu_Cashier();
                                
                                frmCashier.Show();
                            }
                        }
                        else
                        {
                            if (ustatus == "Disabled")
                            {
                                con.Close();
                                MessageBox.Show("Your Account has been disabled", "Account Disabled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtUserName.Text = "    Enter  Username";
                                btnShowPass.BringToFront();
                                txtPassword.UseSystemPasswordChar = false;
                                txtPassword.Text = "    Enter  Password";

                            }
                        }
                    }
                   

                    
                
                else
                {
                    con.Close();
                    MessageBox.Show("Invalid Username or Password","Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    txtUserName.Text = "    Enter  Username";
                    txtPassword.Text = "    Enter  Password";
                    txtPassword.UseSystemPasswordChar = false;
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("TRY AGAIN WITH VALID INPUTS", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Text = "    Enter  Username";
                txtPassword.Text = "    Enter  Password";
                return;
                
            }
            finally
            {
                con.Close();
            }

        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
        }



   
    }
}
