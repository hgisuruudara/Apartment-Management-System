using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Apartment_Management_System
{
    class Tenant
    {
        //Instance variables
        private string tenid;
        private string resid;
        private string regdate;
        private string tentitle;
        private string tenfname;
        private string tenlname;
        private string tennic;
        private string tencontact;
        private string tenemail;
        private int result;

        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader dreader;
        private string sql;

        public string Tenid
        {
            get { return tenid; }
            set { tenid = value; }
        }


        public string Resid
        {
            get { return resid; }
            set { resid = value; }
        }

        public string Regdate
        {
            get { return regdate; }
            set { regdate = value; }
        }

        public string Tentitle
        {
            get { return tentitle; }
            set { tentitle = value; }
        }

        public string Tenfname
        {
            get { return tenfname; }
            set { tenfname = value; }
        }

        public string Tenlname
        {
            get { return tenlname; }
            set { tenlname = value; }
        }

        public string Tennic
        {
            get { return tennic; }
            set { tennic = value; }
        }


        public string Tencontact
        {
            get { return tencontact; }
            set { tencontact = value; }
        }

        public string Tenemail
        {
            get { return tenemail; }
            set { tenemail = value; }
        }

        public Tenant()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);
        }

        public int searchTenant(string tid)
        {
            result = 0;
            try
            {
                sql = "SELECT * FROM tbl_tenantDetails WHERE tenant_Id = @tid";
                com = new SqlCommand(sql, con);
                com.Parameters.Add("@tid", SqlDbType.Char, 9, "tenant_Id").Value = tid;

                con.Open();
                dreader = com.ExecuteReader();
                if (dreader.HasRows == true)
                {

                    dreader.Read();

                    this.tenid = dreader["tenant_Id"].ToString();
                    this.resid = dreader["res_unitID"].ToString();
                    this.tentitle = dreader["tenant_Title"].ToString();
                    this.tenfname = dreader["tenant_Fn"].ToString();
                    this.tenlname = dreader["tenant_Ln"].ToString();
                    this.tennic = dreader["tenant_nic"].ToString();
                    this.tencontact = dreader["tenant_contact"].ToString();
                    this.tenemail = dreader["tenant_email"].ToString();
                    this.regdate = dreader["reg_Date"].ToString();
         


                    dreader.Close();
                    result = 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public int updateTenant()
        {
            result = 0;
            try
            {



                sql = "UPDATE tbl_tenantDetails SET tenant_Id=@tid,tenant_Title=@ttitle,tenant_Fn=@tfn,tenant_Ln=@tln,tenant_nic=@tnic,tenant_contact=@tcontact,tenant_email=@temail WHERE tenant_Id=@tid";
                
                com = new SqlCommand(sql, con);

                com.Parameters.Add("@tid", SqlDbType.VarChar, 9, "tenant_Id").Value = this.tenid;
                com.Parameters.Add("@ttitle", SqlDbType.VarChar, 10, "tenant_Title").Value = this.tentitle;
                com.Parameters.Add("@tfn", SqlDbType.VarChar, 30, "tenant_Fn").Value = this.tenfname;
                com.Parameters.Add("@tln", SqlDbType.VarChar, 30, "tenant_Ln").Value = this.tenlname;
                com.Parameters.Add("@tnic", SqlDbType.VarChar, 12, "tenant_nic").Value = this.tennic;
                com.Parameters.Add("@tcontact", SqlDbType.VarChar, 11, "tenant_contact").Value = this.tencontact;
                com.Parameters.Add("@temail", SqlDbType.VarChar, 30, "tenant_email").Value = this.tenemail;


                               
                con.Open();
                com.ExecuteNonQuery();
                result = 1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return result;
        }



        public int deleteTenant(string tid)
        {
            result = 0;
            try
            {
                sql = "DELETE FROM tbl_tenantDetails WHERE tenant_Id=@tid";
                com = new SqlCommand(sql, con);
                com.Parameters.Add("@tid", SqlDbType.VarChar, 9, "tenant_Id").Value = tid;

                con.Open();
                com.ExecuteNonQuery();
                result = 1;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return result;
        }
    }
}
