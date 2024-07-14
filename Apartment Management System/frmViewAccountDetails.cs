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
    public partial class frmViewAccountDetails : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand com;
        SqlDataReader dreader;
        DataTable dt;
        DataRow dr;
        string sql;
        public frmViewAccountDetails()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);
        }

        private void frmViewAccountDetails_Load(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT emp_regDate,emp_id,emp_title,emp_fn,emp_ln,emp_nic,emp_address_no,emp_address_street,emp_address_city,emp_address_state,emp_contact,emp_email,emp_type,emp_status FROM tbl_empRegister";
            com = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(com);
            ada.Fill(dt);
            bunViewAccountDetails.DataSource = dt;
            con.Close();
        }

        private void txtSearchdetails_OnValueChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT emp_regDate,emp_id,emp_title,emp_fn,emp_ln,emp_nic,emp_address_no,emp_address_street,emp_address_city,emp_address_state,emp_contact,emp_email,emp_type,emp_status FROM tbl_empRegister WHERE  emp_id  like '%" + txtSearchdetails.Text + "%' OR emp_nic like '%" + txtSearchdetails.Text + "%'OR emp_fn like '%" + txtSearchdetails.Text + "%'";
            com = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(com);
            ada.Fill(dt);
            bunViewAccountDetails.DataSource = dt;
            con.Close();
        }
    }
}
