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
    public partial class frmViewPayHistory : Form

    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand com;
        SqlDataReader dreader;
        DataTable dt;
        DataRow dr;
        string sql;
        public frmViewPayHistory()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);
        }

        private void frmViewPayHistory_Load(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT * FROM tbl_addPayment";
            com = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(com);
            ada.Fill(dt);
            bunViewPayDetails.DataSource = dt;
            con.Close();
        }

        private void txtSearchdetails_OnValueChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT * FROM tbl_addPayment WHERE  invoice_ID  like '%" + txtSearchdetails.Text + "%' OR cus_name like '%" + txtSearchdetails.Text + "%'OR cus_nic like '%" + txtSearchdetails.Text + "%' OR invoice_type like '%" + txtSearchdetails.Text + "%' OR pay_category like '%" + txtSearchdetails.Text + "%'";
            com = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(com);
            ada.Fill(dt);
            bunViewPayDetails.DataSource = dt;
            con.Close();
        }
    }
}
