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
    class Maintanance
    {

        //Instance variables
        private DateTime reqdate;
        private string mid;
        private string owntenid;
        private string maintaintype;
        private string maintainarea;
        private decimal aproxcost;
        private string maintainmonth;
        private string problemdes;
        private int result;


        //instace Variable of apartments
        private string apartid;
        private string apartname;
        private string apartlocation;
        private string aparttype;

        //instace Variable of Residents
        private string resid;
        private string resname;
        private string reslocation;

        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader dreader;
        private string sql;



        public DateTime Reqdate
    {
        get { return reqdate; }
        set { reqdate = value; }
    }
        public string Mid
        {
            get { return mid; }
            set { mid = value; }
        }


        public string Owntenid
        {
            get { return owntenid; }
            set { owntenid = value; }
        }

        public string Maintaintype
        {
            get { return maintaintype; }
            set { maintaintype = value; }
        }

        public string Maintainarea
        {
            get { return maintainarea; }
            set { maintainarea = value; }
        }

        public decimal Aproxcost
        {
            get { return aproxcost; }
            set { aproxcost = value; }
        }

        public string Maintainmonth
        {
            get { return maintainmonth; }
            set { maintainmonth = value; }
        }

        public string Problemdes
        {
            get { return problemdes; }
            set { problemdes = value; }
        }


        public string Apartid
        {
            get { return apartid; }
            set { apartid = value; }
        }
        public string Apartname
        {
            get { return apartname; }
            set { apartname = value; }
        }
        public string Apartlocation
        {
            get { return apartlocation; }
            set { apartlocation = value; }
        }
        public string Aparttype
        {
            get { return aparttype; }
            set { aparttype = value; }
        }


        public string Resid
        {
            get { return resid; }
            set { resid = value; }
        }
        public string Resname
        {
            get { return resname; }
            set { resname = value; }
        }
        public string Reslocation
        {
            get { return reslocation; }
            set { reslocation = value; }
        }


        public Maintanance()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);
        }

        public string getReqId()
        {
            string mid = "";
            try
            {
                sql = "SELECT TOP (1) mantain_ID  FROM tbl_maintainanceDetails ORDER BY mantain_ID DESC";
                com = new SqlCommand(sql, con);
                con.Open();
                dreader = com.ExecuteReader();
                if (dreader.HasRows == true)
                {
                    dreader.Read();
                    string id = dreader["mantain_ID"].ToString(); //Search for Largest Request id in the table eg. REQ/00016
                    int num = int.Parse(id.Substring(4, 5)) + 1;
                    mid = "REQ/" + num.ToString().PadLeft(5, '0');
                    dreader.Close();
                }
                else
                {
                    mid = "REQ/00001";
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
            return mid;
        }

        public int searchMaintenanceReq(string mid)
        {
            result = 0;
            try
            {
                sql = "SELECT tbl_maintainanceDetails.mantain_ID,tbl_maintainanceDetails.request_datetime,tbl_maintainanceDetails.mantain_type,tbl_maintainanceDetails.mantain_area,tbl_maintainanceDetails.problem_desc,tbl_maintainanceDetails.approx_cost,tbl_maintainanceDetails.mantain_Month,tbl_maintainanceDetails.res_unitID,tbl_maintainanceDetails.owner_Id_tenant_Id,tbl_addApartments.apart_type,tbl_addApartments.apart_name,tbl_addApartments.apart_location,tbl_addResidents.res_name,tbl_addResidents.res_blockLocation,tbl_addResidents.apart_id FROM tbl_maintainanceDetails INNER JOIN tbl_addResidents ON tbl_maintainanceDetails.res_unitID = tbl_addResidents.res_unitID join tbl_addApartments ON tbl_addResidents.apart_id = tbl_addApartments.apart_id WHERE mantain_ID=@mid";
                com = new SqlCommand(sql, con);
                com.Parameters.Add("@mid", SqlDbType.Char, 9, "mantain_ID").Value = mid;

                con.Open();
                dreader = com.ExecuteReader();
                if (dreader.HasRows == true)
                {

                    dreader.Read();

                    this.mid = dreader["mantain_ID"].ToString();
                   this.reqdate = DateTime.Parse( dreader["request_datetime"].ToString());
                   this.maintaintype = dreader["mantain_type"].ToString();
                   this.maintainarea =dreader["mantain_area"].ToString();
                   this.problemdes = dreader["problem_desc"].ToString();
                   this.aproxcost = decimal.Parse(dreader["approx_cost"].ToString());
                   this.problemdes = dreader["problem_desc"].ToString();
                   this.maintainmonth = dreader["mantain_Month"].ToString();
                   this.resid = dreader["res_unitID"].ToString();
                   this.owntenid = dreader["owner_Id_tenant_Id"].ToString();


                   this.apartid= dreader["apart_id"].ToString();
                   this.apartname = dreader["apart_name"].ToString();
                   this.apartlocation = dreader["apart_location"].ToString();
                   this.aparttype = dreader["apart_type"].ToString();

                   this.resid = dreader["res_unitID"].ToString();
                   this.resname= dreader["res_name"].ToString();
                   this.reslocation = dreader["res_blockLocation"].ToString();

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


        public int insertMaintainReq()
        {
            result = 0;
            try
            {
                sql = "INSERT INTO tbl_maintainanceDetails(mantain_ID,request_datetime,mantain_type,mantain_area,problem_desc,approx_cost,mantain_Month,res_unitID,owner_Id_tenant_Id) VALUES(@mid,@rqdate,@mtype,@marea,@mproblemdes,@maproxcost,@mmonth,@rid,@owntenid)";
                com = new SqlCommand(sql, con);




                com.Parameters.Add("@mid", SqlDbType.VarChar, 9, "mantain_ID").Value = this.mid;
                com.Parameters.Add("@rqdate", SqlDbType.DateTime, 4, "request_datetime").Value = this.reqdate;
                com.Parameters.Add("@mtype", SqlDbType.VarChar, 30, "mantain_type").Value = this.maintaintype;
                com.Parameters.Add("@marea", SqlDbType.VarChar, 30, "mantain_area").Value = this.maintainarea;
                com.Parameters.Add("@mproblemdes", SqlDbType.VarChar, 200, "problem_desc").Value = this.problemdes;
                com.Parameters.Add("@maproxcost", SqlDbType.Decimal, 18, "approx_cost").Value = this.aproxcost;
                com.Parameters.Add("@mmonth", SqlDbType.VarChar, 30,"mantain_Month").Value = this.maintainmonth;
                com.Parameters.Add("@rid", SqlDbType.VarChar, 9, "res_unitID").Value = this.resid;
                com.Parameters.Add("@owntenid", SqlDbType.VarChar, 9, "owner_Id_tenant_Id").Value = this.owntenid;

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


        public int updateMaintenance()
        {
            result = 0;
            try
            {


                //UPDATE RECORD
                sql = "UPDATE tbl_maintainanceDetails SET mantain_type=@mtype,mantain_area=@marea,problem_desc=@mproblemdes,approx_cost=@maproxcost,mantain_Month=@mmonth,res_unitID=@rid,owner_Id_tenant_Id=@owntenid WHERE mantain_ID=@mid";
                com = new SqlCommand(sql, con);

                com.Parameters.Add("@mid", SqlDbType.VarChar,9, "mantain_ID").Value = this.mid;
                com.Parameters.Add("@mtype", SqlDbType.VarChar,30,"mantain_type").Value = this.maintaintype;
                com.Parameters.Add("@marea", SqlDbType.VarChar, 30,"mantain_area").Value = this.maintainarea;
                com.Parameters.Add("@mproblemdes", SqlDbType.VarChar, 200, "problem_desc").Value = this.problemdes;
                com.Parameters.Add("@maproxcost", SqlDbType.Decimal, 18,"approx_cost").Value = this.aproxcost;
                com.Parameters.Add("@mmonth", SqlDbType.VarChar, 30,"mantain_Month").Value = this.maintainmonth;
                com.Parameters.Add("@rid", SqlDbType.VarChar, 9,"res_unitID").Value = this.resid;
                com.Parameters.Add("@owntenid", SqlDbType.VarChar, 9, "owner_Id_tenant_Id").Value = this.owntenid;
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

        public int deleteMaintenance(string mid)
        {
            result = 0;
            try
            {
                sql = "DELETE FROM tbl_maintainanceDetails WHERE mantain_ID=@mid";
                com = new SqlCommand(sql, con);
                com.Parameters.Add("@mid", SqlDbType.VarChar, 9,"mantain_ID").Value=mid;

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
