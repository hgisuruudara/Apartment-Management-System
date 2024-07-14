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
    public partial class frmDashBoardAdmin : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand com;
        SqlDataReader dreader;
        public frmDashBoardAdmin()
        {
            InitializeComponent();

            timer1.Start();
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhrs.Text = DateTime.Now.ToString("HH:mm:ss");
            lbldate.Text = DateTime.Now.ToString("MMM dd yyyy,");
            lblday.Text = DateTime.Now.ToString("dddd");
        }

        private void lable_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblJobsNo_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblday_Click(object sender, EventArgs e)
        {

        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void lblhrs_Click(object sender, EventArgs e)
        {

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
                con.Close();
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
                con.Close();
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
                con.Close();
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
                con.Close();
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

            }

        }



        private void frmDashBoardAdmin_Load(object sender, EventArgs e)
        {
            try
            {

                totNoUsers();
                availunits();
                soldUnits();
                rentUnits();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
   
        }
    }
}
