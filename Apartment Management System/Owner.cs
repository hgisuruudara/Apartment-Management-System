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
    class Owner
    {
         //Instance variables
        private string ownid;
        private string resid;
        private string regdate;
        private string owntitle;
        private string ownfname;
        private string ownlname;
        private string ownnic;
        private string owncontact;
        private string ownemail;
        private int result;

        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader dreader;
        private string sql;

        public string Ownid
        {
            get { return ownid; }
            set { ownid = value; }
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

        public string Owntitle
        {
            get { return owntitle; }
            set { owntitle = value; }
        }

        public string Ownfname
        {
            get { return ownfname; }
            set { ownfname = value; }
        }

        public string Ownlname
        {
            get { return ownlname; }
            set { ownlname = value; }
        }

        public string Ownnic
        {
            get { return ownnic; }
            set { ownnic = value; }
        }


        public string Owncontact
        {
            get { return owncontact; }
            set { owncontact = value; }
        }

        public string Ownemail
        {
            get { return ownemail; }
            set { ownemail = value; }
        }

        public Owner()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);
        }

        public int searchOwner(string oid)
        {
            result = 0;
            try
            {
                sql = "SELECT * FROM tbl_ownerDetails WHERE owner_Id = @oid";
                com = new SqlCommand(sql, con);
                com.Parameters.Add("@oid", SqlDbType.Char, 9, "owner_Id").Value = oid;

                con.Open();
                dreader = com.ExecuteReader();
                if (dreader.HasRows == true)
                {

                    dreader.Read();

                    this.ownid = dreader["owner_Id"].ToString();
                    this.resid = dreader["res_unitID"].ToString();
                    this.owntitle = dreader["owner_Title"].ToString();
                    this.ownfname = dreader["owner_Fn"].ToString();
                    this.ownlname = dreader["owner_Ln"].ToString();
                    this.ownnic = dreader["owner_nic"].ToString();
                    this.owncontact = dreader["owner_contact"].ToString();
                    this.ownemail = dreader["owner_email"].ToString();
                    this.regdate = dreader["reg_date"].ToString();
         


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

        public int updateOwner()
        {
            result = 0;
            try
            {


                sql = "UPDATE tbl_ownerDetails SET owner_Id=@oid,owner_Title=@otitle,owner_Fn=@ofn,owner_Ln=@oln,owner_nic=@onic,owner_contact=@ocontact,owner_email=@oemail WHERE owner_Id=@oid";
                
                com = new SqlCommand(sql, con);

                com.Parameters.Add("@oid", SqlDbType.VarChar, 9, "owner_Id").Value = this.ownid;
                com.Parameters.Add("@otitle", SqlDbType.VarChar, 10, "owner_Title").Value = this.owntitle;
                com.Parameters.Add("@ofn", SqlDbType.VarChar, 30, "owner_Fn").Value = this.ownfname;
                com.Parameters.Add("@oln", SqlDbType.VarChar, 30, "owner_Ln").Value = this.ownlname;
                com.Parameters.Add("@onic", SqlDbType.VarChar, 12, "owner_nic").Value = this.ownnic;
                com.Parameters.Add("@ocontact", SqlDbType.VarChar, 11, "owner_contact").Value = this.owncontact;
                com.Parameters.Add("@oemail", SqlDbType.VarChar, 30, "owner_email").Value = this.ownemail;


                               
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



        public int deleteOwner(string oid)
        {
            result = 0;
            try
            {
                sql = "DELETE FROM tbl_ownerDetails WHERE owner_Id=@oid";
                com = new SqlCommand(sql, con);
                com.Parameters.Add("@oid", SqlDbType.VarChar, 9, "owner_Id").Value = oid;

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
