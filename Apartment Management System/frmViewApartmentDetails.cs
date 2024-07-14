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
    public partial class frmViewApartmentDetails : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand com;
        SqlDataReader dreader;
        DataTable dt;
        DataRow dr;
        string sql;
  
        public frmViewApartmentDetails()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);
        }

        private void frmViewApartmentDetails_Load(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT * FROM tbl_addApartments";
            com = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(com);
            ada.Fill(dt);
            bunViewApartDetails.DataSource = dt;
            con.Close();
        }

        private void txtSearchdetails_OnValueChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT * FROM tbl_addApartments WHERE  apart_id  like '%" + txtSearchdetails.Text + "%' OR apart_type like '%" + txtSearchdetails.Text + "%'";
            com = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(com);
            ada.Fill(dt);
            bunViewApartDetails.DataSource = dt;
            con.Close();
        }
    }
}
