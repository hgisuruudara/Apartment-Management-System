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
    class Payment
    {
        //Instance valiables

        private DateTime cusregdate;
        
        private string invid;
        private string owntenmainid;
     
        private string custitle;
        private string cusfname;
        private string cuslname;
        private string cusnic;
        private string cuscontact;
        private string empemail;
        private string cusservice;
        private string paycat;
        private string paymethod;
        private float totamt;
        private float payamt;
        private float balamt;
        private int result;


        //Instance Variables for Searching Resident
        private string resid;
        private string resname;
        private string resblock;
        private int resroom;
        private int resbathroom;
        private string purprice;
        private string rentprice;
        private string resstatus;

        //Instance Variables for Searching Apartments
        private string apartid;
        private string apartname;
        private string apartlocation;
        private string aparttype;



        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader dreader;
        private string sql;


        public DateTime CusRegdate
        {
            get { return cusregdate; }
            set { cusregdate = value; }
        }


        public string Invid
        {
            get { return invid; }
            set { invid = value; }
        }

        public string OwnTenMainid
        {
            get { return owntenmainid; }
            set { owntenmainid = value; }
        }

        public string Apartid
    {
            get { return apartid; }
            set { apartid = value; }
    }
        public string Resid
        {
            get { return resid; }
            set { resid = value; }
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


   


        public string Custitle
        {
            get { return custitle; }
            set { custitle = value; }
        }

        public string CusFname
        {
            get { return cusfname; }
            set { cusfname = value; }
        }

        public string CusLname
        {
            get { return cuslname; }
            set { cuslname = value; }
        }

        public string Cusnic
        {
            get { return cusnic; }
            set { cusnic = value; }
        }


        public string Cuscontact
        {
            get { return cuscontact; }
            set { cuscontact = value; }
        }

        public string Cusemail
        {
            get { return empemail; }
            set { empemail = value; }
        }



        public string Paycat
        {
            get { return paycat; }
            set { paycat = value; }
        }

        public string Paymethod
        {
            get { return paymethod; }
            set { paymethod = value; }
        }


        public float Totamt
        {
            get { return totamt; }
            set { totamt = value; }
        }

        public float Payamt
        {
            get { return payamt; }
            set { payamt = value; }
        }

        public float Balamt
        {
            get { return balamt; }
            set { balamt = value; }
        }



        public string Cusservice
        {
            get { return cusservice; }
            set { cusservice = value; }
        }


        
        public string Resname
        {
            get { return resname; }
            set { resname = value; }
        }
    


      
        public string Resblock
        {
            get { return resblock; }
            set { resblock = value; }
        }

        public string Purprice
        {
            get { return purprice; }
            set { purprice = value; }
        }

 
        public string Rentprice
        {
            get { return rentprice; }
            set { rentprice = value; }
        }

        public string Resstatus
        {
            get { return resstatus; }
            set { resstatus = value; }
        }



        public int Resroom
        {
            get { return resroom; }
            set { resroom = value; }
        }

        public int Resbathroom
        {
            get { return resbathroom; }
            set { resbathroom = value; }
        }

                public Payment()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new SqlConnection(constr);
        }

                public string getInvId()
                {
                    string inid = "";
                    try
                    {
                        sql = "SELECT TOP (1) invoice_ID FROM tbl_addPayment ORDER BY invoice_ID DESC";
                        com = new SqlCommand(sql, con);
                        con.Open();
                        dreader = com.ExecuteReader();
                        if (dreader.HasRows == true)
                        {
                            dreader.Read();
                            string id = dreader["invoice_ID"].ToString(); //Largest employee id in the table eg. EMP00016
                            int num = int.Parse(id.Substring(4, 5)) + 1;
                            inid = "INV/" + num.ToString().PadLeft(5, '0');
                            dreader.Close();
                        }
                        else
                        {
                            inid = "INV/00001";
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
                    return inid;
                }

                public string getOwnId()
                {
                    string owid = "";
                    try
                    {
                        sql = "SELECT TOP (1) owner_Id FROM tbl_ownerDetails ORDER BY owner_Id DESC";
                        com = new SqlCommand(sql, con);
                        con.Open();
                        dreader = com.ExecuteReader();
                        if (dreader.HasRows == true)
                        {
                            dreader.Read();
                            string id = dreader["owner_Id"].ToString(); //Largest employee id in the table eg. EMP00016
                            int num = int.Parse(id.Substring(4, 5)) + 1;
                            owid = "OWN/" + num.ToString().PadLeft(5, '0');
                            dreader.Close();
                        }
                        else
                        {
                            owid = "OWN/00001";
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
                    return owid;
                }

                public string getTenId()
                {
                    string teid = "";
                    try
                    {
                        sql = "SELECT TOP (1) tenant_Id FROM tbl_tenantDetails ORDER BY tenant_Id DESC";
                        com = new SqlCommand(sql, con);
                        con.Open();
                        dreader = com.ExecuteReader();
                        if (dreader.HasRows == true)
                        {
                            dreader.Read();
                            string id = dreader["tenant_Id"].ToString(); //Largest employee id in the table eg. EMP00016
                            int num = int.Parse(id.Substring(4, 5)) + 1;
                            teid = "TEN/" + num.ToString().PadLeft(5, '0');
                            dreader.Close();
                        }
                        else
                        {
                            teid = "TEN/00001";
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
                    return teid;
                }


                public int insertInvoice()
                {
                    result = 0;
                    try
                    {
                        sql = "INSERT INTO tbl_addPayment(inv_dateandtime,invoice_ID,cus_title,cus_Fn,cus_Ln,cus_nic,cus_contact,cus_email,service_type,pay_category,pay_method,total_amount,paying_amount,pay_balance,OwnerID_TenantID_MaintenanceID,res_unitID,apart_id) VALUES(@indate,@inid,@ctitle,@cfname,@clname,@cnic,@ccontact,@cemail,@sertype,@paycategory,@paymethod,@totamnt,@payamt,@paybalance,@ownTenMaintanID,@resid,@aid)";
                        com = new SqlCommand(sql, con);

                        com.Parameters.Add("@indate", SqlDbType.DateTime, 4, "inv_dateandtime").Value = this.cusregdate;
                        com.Parameters.Add("@inid", SqlDbType.VarChar, 9, "invoice_ID").Value = this.invid;
                        com.Parameters.Add("@ctitle", SqlDbType.VarChar, 15, "cus_title").Value = this.custitle;
                        com.Parameters.Add("@cfname", SqlDbType.VarChar, 30, "cus_Fn").Value = this.cusfname;
                        com.Parameters.Add("@clname", SqlDbType.VarChar, 30, "cus_Ln").Value = this.cuslname;
                        com.Parameters.Add("@cnic", SqlDbType.VarChar, 12, "cus_nic").Value = this.cusnic;
                        com.Parameters.Add("@ccontact", SqlDbType.VarChar, 11, "cus_contact").Value = this.cuscontact;
                        com.Parameters.Add("@cemail", SqlDbType.VarChar, 30, "cus_email").Value = this.empemail;
                        com.Parameters.Add("@sertype", SqlDbType.VarChar, 20, "service_type").Value = this.cusservice;
                        com.Parameters.Add("@paycategory", SqlDbType.VarChar, 20, "pay_category").Value = this.paycat;
                        com.Parameters.Add("@paymethod", SqlDbType.VarChar, 20, "pay_method").Value = this.paymethod;
                        com.Parameters.Add("@totamnt", SqlDbType.Float, 4, "total_amount").Value = this.totamt;
                        com.Parameters.Add("@payamt", SqlDbType.Float, 4, "paying_amount").Value = this.payamt;
                        com.Parameters.Add("@paybalance", SqlDbType.Float, 4, "pay_balance").Value = this.balamt;
                        com.Parameters.Add("@ownTenMaintanID", SqlDbType.VarChar, 9, "OwnerID_TenantID_MaintenanceID").Value = this.owntenmainid;
                        com.Parameters.Add("@resid", SqlDbType.VarChar, 9, "res_unitID").Value = this.resid;
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


                public int insertOwner()
                {
                    result = 0;
                    try
                    {
                        sql = "INSERT INTO tbl_ownerDetails(owner_Id,owner_Title,owner_Fn,owner_Ln,owner_nic,owner_contact,owner_email,reg_date,res_unitID) VALUES(@owid,@owtitle,@owfname,@owlname,@ownic,@owcontact,@owemail,@owregdate,@resid)";
                        com = new SqlCommand(sql, con);

                        com.Parameters.Add("@owid", SqlDbType.VarChar, 9, "owner_Id").Value = this.owntenmainid;
                        com.Parameters.Add("@owtitle", SqlDbType.VarChar, 10, "owner_Title").Value = this.custitle;
                        com.Parameters.Add("@owfname", SqlDbType.VarChar, 30, "owner_Fn").Value = this.cusfname;
                        com.Parameters.Add("@owlname", SqlDbType.VarChar, 30, "owner_Ln").Value = this.cuslname;
                        com.Parameters.Add("@ownic", SqlDbType.VarChar, 12, "owner_nic").Value = this.cusnic;
                        com.Parameters.Add("@owcontact", SqlDbType.VarChar, 11, "owner_contact").Value = this.cuscontact;
                        com.Parameters.Add("@owemail", SqlDbType.VarChar, 30, "owner_email").Value = this.empemail;
                         com.Parameters.Add("@owregdate", SqlDbType.DateTime, 4, "reg_date").Value = this.cusregdate;
                        com.Parameters.Add("@resid", SqlDbType.VarChar, 9, "res_unitID").Value = this.resid;
                      


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

                public int insertTenant()
                {
                    result = 0;
                    try
                    {
                        sql = "INSERT INTO tbl_tenantDetails(tenant_Id,tenant_Title,tenant_Fn,tenant_Ln,tenant_nic,tenant_contact,tenant_email,reg_Date,res_unitID) VALUES(@teid,@tetitle,@tefname,@telname,@tenic,@tecontact,@teemail,@tenregdate,@resid)";
                        com = new SqlCommand(sql, con);


                        com.Parameters.Add("@teid", SqlDbType.VarChar, 9, "tenant_Id").Value = this.owntenmainid;
                        com.Parameters.Add("@tetitle", SqlDbType.VarChar, 10, "tenant_Title").Value = this.custitle;
                        com.Parameters.Add("@tefname", SqlDbType.VarChar, 30, "tenant_Fn").Value = this.cusfname;
                        com.Parameters.Add("@telname", SqlDbType.VarChar, 30, "tenant_Ln").Value = this.cuslname;
                        com.Parameters.Add("@tenic", SqlDbType.VarChar, 12, "tenant_nic").Value = this.cusnic;
                        com.Parameters.Add("@tecontact", SqlDbType.VarChar, 11, "tenant_contact").Value = this.cuscontact;
                        com.Parameters.Add("@teemail", SqlDbType.VarChar, 30, "tenant_email").Value = this.empemail;
                        com.Parameters.Add("@tenregdate", SqlDbType.DateTime, 4, "reg_Date").Value = this.cusregdate;
                        com.Parameters.Add("@resid", SqlDbType.VarChar, 9, "res_unitID").Value = this.resid;



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


                public int searchInvoice(string invid)
                {
                    result = 0;
                    try
                    {
                        sql = "SELECT tbl_addPayment.invoice_ID, tbl_addPayment.cus_title, tbl_addPayment.cus_Fn,tbl_addPayment.cus_Ln,tbl_addPayment.cus_nic,tbl_addPayment.cus_contact, tbl_addPayment.cus_email,tbl_addPayment.pay_category, tbl_addPayment.service_type,tbl_addPayment.pay_method,tbl_addPayment.total_amount,tbl_addPayment.paying_amount,tbl_addPayment.pay_balance,tbl_addPayment.OwnerID_TenantID_MaintenanceID, tbl_addResidents.res_unitID,tbl_addResidents.res_name,tbl_addResidents.res_blockLocation,tbl_addResidents.res_price,tbl_addResidents.res_rentAmt,tbl_addResidents.res_Status,tbl_addResidents.res_noOfRooms,tbl_addResidents.res_noOfBathRooms,tbl_addResidents.apart_id,tbl_addApartments.apart_type,tbl_addApartments.apart_location,tbl_addApartments.apart_name FROM tbl_addPayment INNER JOIN tbl_addResidents ON tbl_addPayment.res_unitID=tbl_addResidents.res_unitID join tbl_addApartments ON tbl_addResidents.apart_id = tbl_addApartments.apart_id WHERE tbl_addPayment.invoice_ID = @inid";
                        com = new SqlCommand(sql, con);
                        com.Parameters.Add("@inid", SqlDbType.Char, 9, "invoice_ID").Value = invid;

                        con.Open();
                        dreader = com.ExecuteReader();
                        if (dreader.HasRows == true)
                        {

                            dreader.Read();


                            this.invid = dreader["invoice_ID"].ToString();

                            this.custitle = dreader["cus_title"].ToString();
                            this.cusfname = dreader["cus_Fn"].ToString();
                            this.cuslname = dreader["cus_Ln"].ToString();
                            this.cusnic = dreader["cus_nic"].ToString();
                            this.cuscontact = dreader["cus_contact"].ToString();
                            this.empemail = dreader["cus_email"].ToString();
                            this.paycat = dreader["pay_category"].ToString();

                            this.cusservice = dreader["service_type"].ToString();
                            
                            this.paymethod = dreader["pay_method"].ToString();



                            this.totamt = float.Parse(dreader["total_amount"].ToString());

                            this.payamt = float.Parse(dreader["paying_amount"].ToString());

                            this.balamt = float.Parse(dreader["pay_balance"].ToString());

                            this.owntenmainid = dreader["OwnerID_TenantID_MaintenanceID"].ToString();


                            this.resid = dreader["res_unitID"].ToString();
                            this.resname = dreader["res_name"].ToString();
                            this.resblock = dreader["res_blockLocation"].ToString();
                            this.resroom = int.Parse(dreader["res_noOfRooms"].ToString());
                            this.resbathroom = int.Parse(dreader["res_noOfBathRooms"].ToString());



                            this.purprice = dreader["res_price"].ToString();
                            this.rentprice = dreader["res_rentAmt"].ToString();
                            this.resstatus = dreader["res_Status"].ToString();

                            this.apartid = dreader["apart_id"].ToString();
                            this.apartname = dreader["apart_name"].ToString();
                            this.apartlocation = dreader["apart_location"].ToString();
                            this.aparttype = dreader["apart_type"].ToString();



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


                public int updateInvoice()
                {
                    result = 0;
                    try
                    {


                        sql = "UPDATE tbl_addPayment SET invoice_ID=@inid,cus_title=@ctitle,cus_Fn=@cfname,cus_Ln=@clname,cus_nic=@cnic,cus_contact=@ccontact,cus_email=@cemail,service_type=@sertype,pay_category =@paycategory,pay_method=@paymethod,total_amount =@totamnt,paying_amount=@payamt,pay_balance=@paybalance,OwnerID_TenantID_MaintenanceID =@ownTenMaintanID,res_unitID=@resid,apart_id=@aid WHERE invoice_ID=@inid";
                        com = new SqlCommand(sql, con);


                        com.Parameters.Add("@inid", SqlDbType.VarChar, 9, "invoice_ID").Value = this.invid;
                        com.Parameters.Add("@ctitle", SqlDbType.VarChar, 15, "cus_title").Value = this.custitle;
                        com.Parameters.Add("@cfname", SqlDbType.VarChar, 30, "cus_Fn").Value = this.cusfname;
                        com.Parameters.Add("@clname", SqlDbType.VarChar, 30, "cus_Ln").Value = this.cuslname;
                        com.Parameters.Add("@cnic", SqlDbType.VarChar, 12, "cus_nic").Value = this.cusnic;
                        com.Parameters.Add("@ccontact", SqlDbType.VarChar, 11, "cus_contact").Value = this.cuscontact;
                        com.Parameters.Add("@cemail", SqlDbType.VarChar, 30, "cus_email").Value = this.empemail;
                        com.Parameters.Add("@sertype", SqlDbType.VarChar, 20, "service_type").Value = this.cusservice;
                        com.Parameters.Add("@paycategory", SqlDbType.VarChar, 20, "pay_category").Value = this.paycat;
                        com.Parameters.Add("@paymethod", SqlDbType.VarChar, 20, "pay_method").Value = this.paymethod;
                        com.Parameters.Add("@totamnt", SqlDbType.Float, 4, "total_amount").Value = this.totamt;
                        com.Parameters.Add("@payamt", SqlDbType.Float, 4, "paying_amount").Value = this.payamt;
                        com.Parameters.Add("@paybalance", SqlDbType.Float, 4, "pay_balance").Value = this.balamt;
                        com.Parameters.Add("@ownTenMaintanID", SqlDbType.VarChar, 9, "OwnerID_TenantID_MaintenanceID").Value = this.owntenmainid;
                        com.Parameters.Add("@resid", SqlDbType.VarChar, 9, "res_unitID").Value = this.resid;
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

                public int deleteInvoice(string inid)
                {
                    result = 0;
                    try
                    {
                        sql = "DELETE FROM tbl_addPayment WHERE invoice_ID=@inid";
                        com = new SqlCommand(sql, con);
                        com.Parameters.Add("@inid", SqlDbType.VarChar, 9, "invoice_ID").Value = inid;

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
