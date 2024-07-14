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
    public partial class frmViewHistory : Form
    {

        SqlConnection con;
      
        SqlCommand com;
 
        
        public frmViewHistory()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);
        }

        private void frmViewHistory_Load(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT * FROM tbl_systemTaskHistory";
            com = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(com);
            ada.Fill(dt);
            bunViewHistoryDetails.DataSource = dt;
            con.Close();
        }

        private void txtSearchdetails_OnValueChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT * FROM tbl_systemTaskHistory WHERE  task_ID  like '%" + txtSearchdetails.Text + "%' OR task_description like '%" + txtSearchdetails.Text + "%'OR emp_id like '%" + txtSearchdetails.Text + "%'"; 
            com = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(com);
            ada.Fill(dt);
            bunViewHistoryDetails.DataSource = dt;
            con.Close();
        }
    }
}
