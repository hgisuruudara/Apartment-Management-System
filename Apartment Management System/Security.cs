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
    class Security
    {
        //Instance variables
        private string secid;
        private string sectitle;
        private string secfname;
        private string seclname;
        private string secnic;
        private string seccontact;
        private string seccompany;
        private string seccompanycontact;

        private DateTime dutyonDate;
        private DateTime dutyOffDate;
        private TimeSpan dutyonTime;
        private TimeSpan dutyOffTime;
        private int result;




        //instace Variable of apartments
        private string apartid;
        private string apartname;
        private string apartlocation;
        private string aparttype;
        private int apartresidentunit;


        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader dreader;
        private string sql;

        public string Secid
        {
            get { return secid; }
            set { secid = value; }
        }
        public string Sectitle
        {
            get { return sectitle; }
            set { sectitle = value; }
        }
        public string Secfname
         {
             get { return secfname; }
             set { secfname = value; }
        }
        public string Seclname
        {
            get { return seclname; }
            set { seclname = value; }
        }
        public string Secnic
        {
            get { return secnic; }
            set { secnic = value; }
        }
        public string Seccontact
        {
            get { return seccontact; }
            set { seccontact = value; }
        }

        public string Seccompany
                      {
            get { return seccompany; }
            set { seccompany = value; }
        }
        public string Seccompanycontact
                   {
            get { return seccompanycontact; }
            set { seccompanycontact = value; }
        }

        public DateTime DutyonDate
                   {
            get { return dutyonDate; }
            set { dutyonDate = value; }
        }
        public DateTime DutyOffDate
                   {
            get { return dutyOffDate; }
            set { dutyOffDate = value; }
        }
        public TimeSpan DutyonTime
                   {
            get { return dutyonTime; }
            set { dutyonTime = value; }
        }
        public TimeSpan DutyOffTime
                   {
            get { return dutyOffTime; }
            set { dutyOffTime = value; }
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

        public int Apartresidentunit
        {
            get { return apartresidentunit; }
            set { apartresidentunit = value; }
        }


        public Security()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);
        }


        public int insertSecurity()
        {
            result = 0;
            try
            {
                sql = "INSERT INTO tbl_secDetails(secguard_ID,secguard_Title,secguard_Fn,secguard_Ln,secguard_nic,secguard_contact,secguard_company,secguard_companyTel,dutyon_DateTime,dutyoff_DateTime,dutyontime,dutyofftime,apart_id) VALUES(@sid,@atitle,@sfn,@sln,@snic,@scontact,@scompany,@scompanytel,@sdutyondate,@sdutyontime,@sdutyoffdate,@sdutyofftime,@aid)";
                com = new SqlCommand(sql, con);

 
                com.Parameters.Add("@sid", SqlDbType.VarChar, 9, "secguard_ID").Value = this.secid;
                com.Parameters.Add("@atitle", SqlDbType.VarChar, 10, "secguard_Title").Value = this.sectitle;
                com.Parameters.Add("@sfn", SqlDbType.VarChar, 30, "secguard_Fn").Value = this.secfname;
                com.Parameters.Add("@sln", SqlDbType.VarChar, 30, "secguard_Ln").Value = this.seclname;
                com.Parameters.Add("@snic", SqlDbType.VarChar, 12, "secguard_nic").Value = this.secnic;
                com.Parameters.Add("@scontact", SqlDbType.VarChar, 11, "secguard_contact").Value = this.seccontact;
                com.Parameters.Add("@scompany", SqlDbType.VarChar, 30, "secguard_company").Value = this.seccompany;
                com.Parameters.Add("@scompanytel", SqlDbType.VarChar, 11, "secguard_companyTel").Value = this.seccompanycontact;
                com.Parameters.Add("@sdutyondate", SqlDbType.Date, 4, "dutyon_DateTime").Value = this.dutyonDate;
                com.Parameters.Add("@sdutyontime", SqlDbType.Time, 4, "dutyontime").Value = this.dutyonTime;
                com.Parameters.Add("@sdutyoffdate", SqlDbType.Date, 4, "dutyoff_DateTime").Value = this.dutyOffDate;
                com.Parameters.Add("@sdutyofftime", SqlDbType.Time, 4, "dutyofftime").Value = this.dutyOffTime;
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




        public int searchSecurity(string sid)
        {
            result = 0;
            try
            {
                sql = "SELECT tbl_secDetails.secguard_ID,tbl_secDetails.secguard_Title,tbl_secDetails.secguard_Fn,tbl_secDetails.secguard_Ln,tbl_secDetails.secguard_nic,tbl_secDetails.secguard_contact,tbl_secDetails.secguard_company,tbl_secDetails.secguard_companyTel,tbl_secDetails.dutyon_DateTime,tbl_secDetails.dutyontime,tbl_secDetails.dutyoff_DateTime,tbl_secDetails.dutyofftime,tbl_addApartments.apart_id,tbl_addApartments.apart_name,tbl_addApartments.apart_location,tbl_addApartments.apart_type,tbl_addApartments.apart_residentialunits FROM tbl_secDetails INNER JOIN tbl_addApartments ON tbl_secDetails.apart_id = tbl_addApartments.apart_id  WHERE secguard_ID=@sid";
                com = new SqlCommand(sql, con);
                com.Parameters.Add("@sid", SqlDbType.Char, 9, "secguard_ID").Value = sid;

                con.Open();
                dreader = com.ExecuteReader();
                if (dreader.HasRows == true)
                {

                    dreader.Read();


                    this.secid = dreader["secguard_ID"].ToString();
                    this.sectitle = dreader["secguard_Title"].ToString();
                    this.secfname = dreader["secguard_Fn"].ToString();
                    this.seclname =dreader["secguard_Ln"].ToString();
                    this.secnic = dreader["secguard_nic"].ToString();
                    this.seccontact = dreader["secguard_contact"].ToString();
                    this.seccompany = dreader["secguard_company"].ToString();
                    this.seccompanycontact = dreader["secguard_companyTel"].ToString();

                    this.dutyonDate = DateTime.Parse(dreader["dutyon_DateTime"].ToString());
                    this.dutyOffDate = DateTime.Parse(dreader["dutyoff_DateTime"].ToString());
                    this.dutyonTime = TimeSpan.Parse(dreader["dutyontime"].ToString());
                    this.dutyOffTime = TimeSpan.Parse(dreader["dutyofftime"].ToString());
                    this.apartid = dreader["apart_id"].ToString();
                    this.apartname =dreader["apart_name"].ToString();
                    this.apartlocation = dreader["apart_location"].ToString();

                    this.aparttype = dreader["apart_type"].ToString();
                    this.apartresidentunit = int.Parse(dreader["apart_residentialunits"].ToString());

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


        public int updateSecurity()
        {
            result = 0;
            try
            {

                

                sql = "UPDATE tbl_secDetails SET secguard_ID=@sid,secguard_Title=@atitle,secguard_Fn=@sfn,secguard_Ln=@sln,secguard_nic=@snic,secguard_contact=@scontact,secguard_company=@scompany,secguard_companyTel=@scompanytel,dutyon_DateTime=@sdutyondate,dutyontime=@sdutyontime,dutyoff_DateTime=@sdutyoffdate,dutyofftime=@sdutyofftime,apart_id=@aid WHERE secguard_ID=@sid";
                com = new SqlCommand(sql, con);


                com.Parameters.Add("@sid", SqlDbType.VarChar, 9, "secguard_ID").Value = this.secid;
                com.Parameters.Add("@atitle", SqlDbType.VarChar, 10, "secguard_Title").Value = this.sectitle;
                com.Parameters.Add("@sfn", SqlDbType.VarChar, 30, "secguard_Fn").Value = this.secfname;
                com.Parameters.Add("@sln", SqlDbType.VarChar, 30, "secguard_Ln").Value = this.seclname;
                com.Parameters.Add("@snic", SqlDbType.VarChar, 12, "secguard_nic").Value = this.secnic;
                com.Parameters.Add("@scontact", SqlDbType.VarChar, 11, "secguard_contact").Value = this.seccontact;
                com.Parameters.Add("@scompany", SqlDbType.VarChar, 30, "secguard_company").Value = this.seccompany;
                com.Parameters.Add("@scompanytel", SqlDbType.VarChar, 11, "secguard_companyTel").Value = this.seccompanycontact;
                com.Parameters.Add("@sdutyondate", SqlDbType.Date, 4, "dutyon_DateTime").Value = this.dutyonDate;
                com.Parameters.Add("@sdutyontime", SqlDbType.Time, 4, "dutyontime").Value = this.dutyonTime;
                com.Parameters.Add("@sdutyoffdate", SqlDbType.Date, 4, "dutyoff_DateTime").Value = this.dutyOffDate;
                com.Parameters.Add("@sdutyofftime", SqlDbType.Time, 4, "dutyofftime").Value = this.dutyOffTime;
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

        public int deleteSecurity(string sid)
        {
            result = 0;
            try
            {
                sql = "DELETE FROM tbl_secDetails WHERE secguard_ID=@sid";
                com = new SqlCommand(sql, con);
                com.Parameters.Add("@sid", SqlDbType.VarChar, 9, "secguard_ID").Value = sid;

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
