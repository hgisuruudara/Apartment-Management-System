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
    class Apartment
    {
        //Instance variables
        private string apartid;
        private string apartname;
        private string apartlocation;
        private string aparttype;
        private int apartlevel;
        private int apartresidentunit;
        private int apartunitstatus;
        private int result;

        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader dreader;
        private string sql;


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

        public int Apartlevel
        {
            get { return apartlevel; }
            set { apartlevel = value; }
        }



        public int Apartresidentunit
        {
            get { return apartresidentunit; }
            set { apartresidentunit = value; }
        }

        public int Apartunitstatus
        {
            get { return apartunitstatus; }
            set { apartunitstatus = value; }
        }

        public Apartment()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);
        }

        public string getApartId()
        {
            string aid = "";
            try
            {
                sql = "SELECT TOP (1) apart_id FROM tbl_addApartments ORDER BY apart_id DESC";
                com = new SqlCommand(sql, con);
                con.Open();
                dreader = com.ExecuteReader();
                if (dreader.HasRows == true)
                {
                    dreader.Read();
                    string id = dreader["apart_id"].ToString(); //Largest employee id in the table eg. EMP00016
                    int num = int.Parse(id.Substring(4, 4)) + 1;
                    aid = "APA/" + num.ToString().PadLeft(4, '0');
                    dreader.Close();
                }
                else
                {
                    aid = "APA/0001";
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
            return aid;
        }


        public int searchApartments(string aid)
        {
            result = 0;
            try
            {
                sql = "SELECT * FROM tbl_addApartments WHERE apart_id = @aid";
                com = new SqlCommand(sql, con);
                com.Parameters.Add("@aid", SqlDbType.Char, 8, "apart_id").Value = aid;

                con.Open();
                dreader = com.ExecuteReader();
                if (dreader.HasRows == true)
                {

                    dreader.Read();


                    this.apartid = dreader["apart_id"].ToString();
                    this.apartname = dreader["apart_name"].ToString();
                    this.apartlocation = dreader["apart_location"].ToString();
                    this.aparttype = dreader["apart_type"].ToString();
                    this.apartlevel =int.Parse( dreader["apart_levels"].ToString());

                    this.apartresidentunit = int.Parse(dreader["apart_residentialunits"].ToString());
                    this.apartunitstatus = int.Parse(dreader["apart_unitAvailaStatus"].ToString());

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

        public int insertApartment()
        {
            result = 0;
            try   
            {
                sql = "INSERT INTO tbl_addApartments(apart_id,apart_name,apart_location,apart_type,apart_levels,apart_residentialunits,apart_unitAvailaStatus) VALUES(@aid,@aname,@alocation,@atype,@alevels,@sresunits,@aapatavail)";
                com = new SqlCommand(sql, con);


                com.Parameters.Add("@aid", SqlDbType.VarChar, 8, "apart_id").Value = this.apartid;
                com.Parameters.Add("@aname", SqlDbType.VarChar, 30, "apart_name").Value = this.apartname;
                com.Parameters.Add("@alocation", SqlDbType.VarChar, 20, "apart_location").Value = this.apartlocation;
                com.Parameters.Add("@atype", SqlDbType.VarChar, 20, "apart_type").Value = this.aparttype;
                com.Parameters.Add("@alevels", SqlDbType.Int, 4, "apart_levels").Value = this.apartlevel;
                com.Parameters.Add("@sresunits", SqlDbType.Int, 4, "apart_residentialunits").Value = this.apartresidentunit;
                com.Parameters.Add("@aapatavail", SqlDbType.Int, 4, "apart_unitAvailaStatus").Value = this.apartunitstatus;
                
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

        public int updateApartment()
        {
            result = 0;
            try
            {
                sql = "UPDATE tbl_addApartments SET apart_id=@aid,apart_name=@aname,apart_location=@alocation,apart_type=@atype,apart_levels=@alevels,apart_residentialunits=@aresunits,apart_unitAvailaStatus=@apartavail WHERE apart_id=@aid";
                com = new SqlCommand(sql, con);

                com.Parameters.Add("@aid", SqlDbType.VarChar, 8, "apart_id").Value = this.apartid;
                com.Parameters.Add("@aname", SqlDbType.VarChar, 30, "apart_name").Value = this.apartname;
                com.Parameters.Add("@alocation", SqlDbType.VarChar, 20, "apart_location").Value = this.apartlocation;
                com.Parameters.Add("@atype", SqlDbType.VarChar, 20, "apart_type").Value = this.aparttype;
                com.Parameters.Add("@alevels", SqlDbType.Int, 4, "apart_levels").Value = this.apartlevel;
                com.Parameters.Add("@aresunits", SqlDbType.Int, 4, "apart_residentialunits").Value = this.apartresidentunit;
                com.Parameters.Add("@apartavail", SqlDbType.Int, 4, "apart_unitAvailaStatus").Value = this.apartunitstatus;
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

        public int deleteApartment(string aid) 
        {
            result = 0;
            try
            {
                sql = "DELETE FROM tbl_addApartments WHERE apart_id=@aid";
                com = new SqlCommand(sql, con);
                com.Parameters.Add("@aid", SqlDbType.VarChar, 8, "apart_id").Value = aid;
                
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
