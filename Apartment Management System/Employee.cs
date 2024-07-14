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
    class Employee
    {
        //Instance valiables
        private DateTime empregdate;
        private string empid;
        private string emptitle;
        private string empfname;
        private string emplname;
        private string empnic;
        private string empcontact;
        private string empaddressno;
        private string empaddressstreet;
        private string empaddresscity;
        private string empaddressstate;
        private string empemail;
        private string empusername;
        private string emppassword;
        private string emptype;
        private string empstatus;
        private int result;

        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader dreader;
        private string sql;



        //Getters and Setters


        public DateTime EmpRegdate
        {
            get { return empregdate; }
            set { empregdate = value; }
        }

        public string Empid
        {
            get { return empid; }
            set { empid = value; }
        }


        public string Emptitle
        {
            get { return emptitle; }
            set { emptitle = value; }
        }

        public string EmpFname
        {
            get { return empfname; }
            set { empfname = value; }
        }

        public string EmpLname
        {
            get { return emplname; }
            set { emplname = value; }
        }

        public string Empnic
        {
            get { return empnic; }
            set { empnic = value; }
        }
      

        public string Empcontact
        {
            get { return empcontact; }
            set { empcontact = value; }
        }

        public string Empaddno
        {
            get { return empaddressno; }
            set { empaddressno = value; }
        }
        public string Empaddstreet
        {
            get { return empaddressstreet; }
            set { empaddressstreet = value; }
        }
        public string Empaddcity
        {
            get { return empaddresscity; }
            set { empaddresscity = value; }
        }
        public string Empaddstate
        {
            get { return empaddressstate; }
            set { empaddressstate = value; }
        }
        public string Empemail
        {
            get { return empemail; }
            set { empemail = value; }
        }

        public string Empusername
        {
            get { return empusername; }
            set { empusername = value; }
        }
        public string Emppassword
        {
            get { return emppassword; }
            set { emppassword = value; }
        }
      
        public string Emptype
        {
            get { return emptype; }
            set { emptype = value; }
        }
        public string Empstatus
        {
            get { return empstatus; }
            set { empstatus = value; }
        }




        public Employee()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);
        }

        public string getEmpId()
        {
            string eid = "";
            try
            {
                sql = "SELECT TOP (1) emp_id FROM tbl_empRegister ORDER BY emp_id DESC";
                com = new SqlCommand(sql, con);
                con.Open();
                dreader = com.ExecuteReader();
                if (dreader.HasRows == true)
                {
                    dreader.Read();
                    string id = dreader["emp_id"].ToString(); //Largest employee id in the table eg. EMP00016
                    int num = int.Parse(id.Substring(4, 5)) + 1;
                    eid = "EMP/" + num.ToString().PadLeft(5, '0');
                    dreader.Close();
                }
                else
                {
                    eid = "EMP/00001";
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
            return eid;
        }

        public int insertEmployee()
        {
            result = 0;
            try
            {
                sql = "INSERT INTO tbl_empRegister(emp_regDate,emp_id,emp_title,emp_fn,emp_ln,emp_nic,emp_address_no,emp_address_street,emp_address_city,emp_address_state,emp_contact,emp_email,emp_username,emp_password,emp_type,emp_status) VALUES(@regdate,@eid,@etitle,@efname,@elname,@enic,@eaddno,@eaddstreet,@eaddcity,@eaddstate,@econtact,@eemail,@eusername,@epassword,@etype,@estatus)";
                com = new SqlCommand(sql, con);


                com.Parameters.Add("@regdate", SqlDbType.DateTime, 4, "emp_regDate").Value = this.empregdate;
                com.Parameters.Add("@eid", SqlDbType.Char, 9, "emp_id").Value = this.empid;
                com.Parameters.Add("@etitle", SqlDbType.VarChar, 10, "emp_title").Value = this.emptitle;
                com.Parameters.Add("@efname", SqlDbType.VarChar, 20, "emp_fn").Value = this.empfname;
                com.Parameters.Add("@elname", SqlDbType.VarChar, 20, "emp_ln").Value = this.emplname;
                com.Parameters.Add("@enic", SqlDbType.VarChar, 12, "emp_nic").Value = this.empnic;
                com.Parameters.Add("@eaddno", SqlDbType.VarChar, 20, "emp_address_no").Value = this.empaddressno;
                com.Parameters.Add("@eaddstreet", SqlDbType.VarChar, 20, "emp_address_street").Value = this.empaddressstreet;
                com.Parameters.Add("@eaddcity", SqlDbType.VarChar, 20, "emp_address_city").Value = this.empaddresscity;
                com.Parameters.Add("@eaddstate", SqlDbType.VarChar, 20, "emp_address_state").Value = this.empaddressstate;
                com.Parameters.Add("@econtact", SqlDbType.VarChar, 11, "emp_contact").Value = this.empcontact;
                com.Parameters.Add("@eemail", SqlDbType.VarChar, 50, "emp_email").Value = this.empemail;
                com.Parameters.Add("@eusername", SqlDbType.VarChar, 30, "emp_username").Value = this.empusername;
                com.Parameters.Add("@epassword", SqlDbType.VarChar, 50, "emp_password").Value = this.emppassword;
                com.Parameters.Add("@etype", SqlDbType.VarChar, 15, "emp_type").Value = this.emptype;
                com.Parameters.Add("@estatus", SqlDbType.VarChar, 8, "emp_status").Value = this.empstatus;
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


        public int searchEmployee(string eid)
        {
            result = 0;
            try
            {
                sql = "SELECT * FROM tbl_empRegister WHERE emp_id = @eid";
                com = new SqlCommand(sql, con);
                com.Parameters.Add("@eid", SqlDbType.Char, 9, "emp_id").Value = eid;
                
                con.Open();
                dreader = com.ExecuteReader();
                if (dreader.HasRows == true)
                {

                        dreader.Read();
                    this.empregdate = DateTime.Parse(dreader["emp_regDate"].ToString());
                    this.empid = dreader["emp_id"].ToString();
                    this.emptitle = dreader["emp_title"].ToString();
                    this.empfname = dreader["emp_fn"].ToString();
                    this.emplname = dreader["emp_ln"].ToString();
                    this.empnic = dreader["emp_nic"].ToString();
                    this.empcontact = dreader["emp_contact"].ToString();
                    this.empaddressno = dreader["emp_address_no"].ToString();
                    this.empaddressstreet = dreader["emp_address_street"].ToString();
                    this.empaddresscity = dreader["emp_address_city"].ToString();
                    this.empaddressstate = dreader["emp_address_state"].ToString();
                    
                    this.empemail = dreader["emp_email"].ToString();
                    this.empusername = dreader["emp_username"].ToString();
                    this.emppassword = dreader["emp_password"].ToString();
                    this.emptype = dreader["emp_type"].ToString();
                    this.empstatus = dreader["emp_status"].ToString();


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




        public int updateEmployee()
        {
            result = 0;
            try
            {
                sql = "UPDATE tbl_empRegister SET emp_regDate=@regdate,emp_id=@eid,emp_title=@etitle,emp_fn=@efname,emp_ln=@elname,emp_nic=@enic,emp_address_no=@eaddno,emp_address_street=@eaddstreet,emp_address_city=@eaddcity,emp_address_state=@eaddstate,emp_contact= @econtact,emp_email=@eemail,emp_type=@etype,emp_status=@estatus WHERE emp_id=@eid";
                com = new SqlCommand(sql, con);
                com.Parameters.Add("@regdate", SqlDbType.DateTime, 4, "emp_regDate").Value = this.empregdate;
                com.Parameters.Add("@eid", SqlDbType.Char, 9, "emp_id").Value = this.empid;
                com.Parameters.Add("@etitle", SqlDbType.VarChar, 10, "emp_title").Value = this.emptitle;
                com.Parameters.Add("@efname", SqlDbType.VarChar, 20, "emp_fn").Value = this.empfname;
                com.Parameters.Add("@elname", SqlDbType.VarChar, 20, "emp_ln").Value = this.emplname;
                com.Parameters.Add("@enic", SqlDbType.VarChar, 12, "emp_nic").Value = this.empnic;
                com.Parameters.Add("@eaddno", SqlDbType.VarChar, 20, "emp_address_no").Value = this.empaddressno;
                com.Parameters.Add("@eaddstreet", SqlDbType.VarChar, 20, "emp_address_street").Value = this.empaddressstreet;
                com.Parameters.Add("@eaddcity", SqlDbType.VarChar, 20, "emp_address_city").Value = this.empaddresscity;
                com.Parameters.Add("@eaddstate", SqlDbType.VarChar, 20, "emp_address_state").Value = this.empaddressstate;
                com.Parameters.Add("@econtact", SqlDbType.VarChar, 11, "emp_contact").Value = this.empcontact;
                com.Parameters.Add("@eemail", SqlDbType.VarChar, 50, "emp_email").Value = this.empemail;

                com.Parameters.Add("@etype", SqlDbType.VarChar, 15, "emp_type").Value = this.emptype;
                com.Parameters.Add("@estatus", SqlDbType.VarChar, 8, "emp_status").Value = this.empstatus;
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

        public int deleteEmployee(string eid)
        {
            result = 0;
            try
            {
                sql = "DELETE FROM tbl_empRegister WHERE emp_id=@eid";
                com = new SqlCommand(sql, con);
                com.Parameters.Add("@eid", SqlDbType.Char, 9, "emp_id").Value = eid;
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
