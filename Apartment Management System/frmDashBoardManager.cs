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

namespace Apartment_Management_System
{
    public partial class frmDashBoardManager : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand com;
        SqlDataReader dreader;

        public frmDashBoardManager()
        {
            InitializeComponent();
            timer1.Start();
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhrs.Text = DateTime.Now.ToString("HH:mm:ss");
            lbldate.Text = DateTime.Now.ToString("MMM dd yyyy,");
            lblday.Text = DateTime.Now.ToString("dddd");
        }



        public void totNoUsers()
        {
            try
            {

                con.Open();
                string sql = "SELECT COUNT (emp_id) FROM tbl_empRegister";


                com = new SqlCommand(sql, con);
                //read from db
                Int32 rows_count = Convert.ToInt32(com.ExecuteScalar());
                com.Dispose();
           
                // display data on the page
                lblTotUsers.ForeColor = Color.White;
                lblTotUsers.Text = rows_count.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }




        public void availunits()
        {
            try
            {

                con.Open();
                string sql = "SELECT COUNT (res_unitID) FROM tbl_addResidents WHERE res_Status='Available'";


                com = new SqlCommand(sql, con);
                //read from db
                Int32 rows_count = Convert.ToInt32(com.ExecuteScalar());
                com.Dispose();
                
                // display data on the page
                lblAvaiUnits.ForeColor = Color.White;
                lblAvaiUnits.Text = rows_count.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }


        public void soldUnits()
        {
            try
            {

                con.Open();
                string sql = "SELECT COUNT (res_unitID) FROM tbl_addResidents WHERE res_Status='Sold'";


                com = new SqlCommand(sql, con);
                //read from db
                Int32 rows_count = Convert.ToInt32(com.ExecuteScalar());
                com.Dispose();
                
                // display data on the page
                lblSoldUnits.ForeColor = Color.White;
                lblSoldUnits.Text = rows_count.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        public void rentUnits()
        {
            try
            {

                con.Open();
                string sql = "SELECT COUNT (res_unitID) FROM tbl_addResidents WHERE res_Status='Rented'";


                com = new SqlCommand(sql, con);
                //read from db
                Int32 rows_count = Convert.ToInt32(com.ExecuteScalar());
                com.Dispose();
                
                // display data on the page
                lblRentedUnits.ForeColor = Color.White;
                lblRentedUnits.Text = rows_count.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }



             public void totIncome()
        {
            try
            {

                con.Open();
                string sql = "SELECT SUM(paying_amount) total FROM tbl_addPayment";


                com = new SqlCommand(sql, con);
                //read from db
                Int32 rows_count = Convert.ToInt32(com.ExecuteScalar());
                com.Dispose();
                
                // display data on the page
                lblTotalIncome.ForeColor = Color.White;
                lblTotalIncome.Text = rows_count.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }


             public void totDuePayments()
             {
                 try
                 {

                     con.Open();
                     string sql = "SELECT SUM(pay_balance) total FROM tbl_addPayment";


                     com = new SqlCommand(sql, con);
                     //read from db
                     Int32 rows_count = Convert.ToInt32(com.ExecuteScalar());
                     com.Dispose();
                     
                     // display data on the page
                     lblduepayments.ForeColor = Color.White;
                     lblduepayments.Text = rows_count.ToString();


                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
                 finally
                 {
                     con.Close();
                 }

             }

             public void totMaintainReq()
             {
                 try
                 {

                     con.Open();
                     string sql = "SELECT COUNT (mantain_ID) FROM tbl_maintainanceDetails";


                     com = new SqlCommand(sql, con);
                     //read from db
                     Int32 rows_count = Convert.ToInt32(com.ExecuteScalar());
                     com.Dispose();

                     // display data on the page
                     lblMaintainReq.ForeColor = Color.White;
                     lblMaintainReq.Text = rows_count.ToString();


                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
                 finally
                 {
                     con.Close();
                 }
             }


        private void frmDashBoardManager_Load(object sender, EventArgs e)
        {
            try
            {

                totNoUsers();
                availunits();
                soldUnits();
                rentUnits();
                totIncome();
                totMaintainReq();
                totDuePayments();
             


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
