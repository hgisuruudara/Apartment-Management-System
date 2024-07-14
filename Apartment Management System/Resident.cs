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
    class Resident
    {
        //Instance variables
        private string resid;
        private string apartid;
        private string resname;
        private string reslocation;
        private int resnoofrooms;
        private int resnoofbath;
        private decimal respurprice;
        private decimal resrentprice;
        private string resstatus;
        private int result;


        //instace Variable of apartments
        private string apartname;
        private string apartlocation;
        private string aparttype;
        private int apartlevel;
        private int apartresidentunit;
        private int apartunitstatus;

        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader dreader;
        private string sql;


        public string Resid
        {
            get { return resid; }
            set { resid = value; }
        }

        public string Apartid
        {
            get { return apartid; }
            set { apartid = value; }
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
        public int Resnoofrooms
        {
            get { return resnoofrooms; }
            set { resnoofrooms = value; }
        }
        public int Resnoofbath
        {
            get { return resnoofbath; }
            set { resnoofbath = value; }
        }
        public decimal Respurprice
        {
            get { return respurprice; }
            set { respurprice = value; }
        }
        public decimal Resrentprice
        {
            get { return resrentprice; }
            set { resrentprice = value; }
        }
        public string Resstatus
        {
            get { return resstatus; }
            set { resstatus = value; }
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
        public Resident()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);
        }


        public string getResId()
        {
            string rid = "";
            try
            {
                sql = "SELECT TOP (1) res_unitID FROM tbl_addResidents ORDER BY res_unitID DESC";
                com = new SqlCommand(sql, con);
                con.Open();
                dreader = com.ExecuteReader();
                if (dreader.HasRows == true)
                {
                    dreader.Read();
                    string id = dreader["res_unitID"].ToString(); //Largest Resident id in the table eg. RES/00016
                    int num = int.Parse(id.Substring(4, 5)) + 1;
                    rid = "RES/" + num.ToString().PadLeft(5, '0');
                    dreader.Close();
                }
                else
                {
                    rid = "RES/00001";
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
            return rid;
        }



        public int insertResident()
        {
            result = 0;
            try
            {
                sql = "INSERT INTO tbl_addResidents(res_unitID,res_name,res_blockLocation,res_noOfRooms,res_noOfBathRooms,res_price,res_rentAmt,res_Status,apart_id) VALUES(@rid,@rname,@rblolocation,@rnorooms,@rnobath,@rpurprice,@rrentprice,@rstatus,@aid)";
                com = new SqlCommand(sql, con);

                com.Parameters.Add("@rid", SqlDbType.VarChar, 9, "res_unitID").Value = this.resid;
                com.Parameters.Add("@rname", SqlDbType.VarChar, 30, "res_name").Value = this.resname;
                com.Parameters.Add("@rblolocation", SqlDbType.VarChar, 30, "res_blockLocation").Value = this.reslocation;
                com.Parameters.Add("@rnorooms", SqlDbType.Int, 4, "res_noOfRooms").Value = this.resnoofrooms;
                com.Parameters.Add("@rnobath", SqlDbType.Int, 4, "res_noOfBathRooms").Value = this.resnoofbath;
                com.Parameters.Add("@rpurprice", SqlDbType.Decimal, 16, "res_price").Value = this.respurprice;
                com.Parameters.Add("@rrentprice", SqlDbType.Decimal, 16, "res_rentAmt").Value = this.resrentprice;
                com.Parameters.Add("@rstatus", SqlDbType.VarChar, 20, "res_Status").Value = this.resstatus;
                com.Parameters.Add("@aid", SqlDbType.VarChar, 8, "apart_id").Value = this.apartid;

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

        public int updateResident()
        {
            result = 0;
            try
            {



                sql = "UPDATE tbl_addResidents SET res_unitID=@rid,res_name=@rname,res_blockLocation=@rblolocation,res_noOfRooms=@rnorooms,res_noOfBathRooms=@rnobath,res_price=@rpurprice,res_rentAmt=@rrentprice,res_Status=@rstatus,apart_id=@aid WHERE res_unitID=@rid";
                com = new SqlCommand(sql, con);

                com.Parameters.Add("@rid", SqlDbType.VarChar, 9, "res_unitID").Value = this.resid;
                com.Parameters.Add("@rname", SqlDbType.VarChar, 30, "res_name").Value = this.resname;
                com.Parameters.Add("@rblolocation", SqlDbType.VarChar, 30, "res_blockLocation").Value = this.reslocation;
                com.Parameters.Add("@rnorooms", SqlDbType.Int, 4, "res_noOfRooms").Value = this.resnoofrooms;
                com.Parameters.Add("@rnobath", SqlDbType.Int, 4, "res_noOfBathRooms").Value = this.resnoofbath;
                com.Parameters.Add("@rpurprice", SqlDbType.Decimal, 16, "res_price").Value = this.respurprice;
                com.Parameters.Add("@rrentprice", SqlDbType.Decimal, 16, "res_rentAmt").Value = this.resrentprice;
                com.Parameters.Add("@rstatus", SqlDbType.VarChar, 20, "res_Status").Value = this.resstatus;
                com.Parameters.Add("@aid", SqlDbType.VarChar, 8, "apart_id").Value = this.apartid;
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

        public int deleteResident(string rid)
        {
            result = 0;
            try
            {
                sql = "DELETE FROM tbl_addResidents WHERE res_unitID=@rid";
                com = new SqlCommand(sql, con);
                com.Parameters.Add("@rid", SqlDbType.VarChar,9, "res_unitID").Value = rid;

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


        public int searchResidents(string rid)
        {
            result = 0;
            try
            {
                sql = "SELECT tbl_addResidents.res_unitID,tbl_addResidents.res_name,tbl_addResidents.res_blockLocation,tbl_addResidents.res_noOfRooms,tbl_addResidents.res_noOfBathRooms,tbl_addResidents.res_price,tbl_addResidents.res_rentAmt,tbl_addResidents.res_Status,tbl_addResidents.apart_id,tbl_addApartments.apart_name,tbl_addApartments.apart_location,tbl_addApartments.apart_type,tbl_addApartments.apart_levels,tbl_addApartments.apart_residentialunits,tbl_addApartments.apart_unitAvailaStatus FROM tbl_addResidents INNER JOIN tbl_addApartments ON tbl_addResidents.apart_id = tbl_addApartments.apart_id  WHERE res_unitID=@rid";
                com = new SqlCommand(sql, con);
                com.Parameters.Add("@rid", SqlDbType.Char, 9, "res_unitID").Value = rid;

                con.Open();
                dreader = com.ExecuteReader();
                if (dreader.HasRows == true)
                {

                    dreader.Read();
                 
                    this.resid = dreader["res_unitID"].ToString();
                   this.resname= dreader["res_name"].ToString();
                   this.reslocation = dreader["res_blockLocation"].ToString();
                   this.resnoofrooms = int.Parse(dreader["res_noOfRooms"].ToString());
                   this.resnoofbath = int.Parse(dreader["res_noOfBathRooms"].ToString());
                   this.respurprice = decimal.Parse(dreader["res_price"].ToString());
                   this.resrentprice = decimal.Parse(dreader["res_rentAmt"].ToString());
                   this.resstatus= dreader["res_Status"].ToString();

                   this.apartid= dreader["apart_id"].ToString();
                   this.apartname = dreader["apart_name"].ToString();
                   this.apartlocation = dreader["apart_location"].ToString();
                   this.aparttype = dreader["apart_type"].ToString();
                   this.apartlevel = int.Parse(dreader["apart_levels"].ToString());
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

    }
}
