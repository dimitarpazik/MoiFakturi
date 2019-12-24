using FakturiFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FakturiFirst.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "data source=ASUS\\SQLEXPRESS; database=MoiFakturi; integrated security=SSPI";
        }
        [HttpPost]
        public ActionResult Verify(Account account)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Firm where Firm_Email='"+account.Firm_Email + "' and Firm_Password='"+account.Firm_Password + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("~/Views/Dashboard/Home.cshtml");
            }
            else
            {
                con.Close();                
                return View("Login");
            }            
        }
        public ActionResult Register(Account account)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "insert into Firm values('"+account.Firm_ID+ "','"+account.Firm_Name+"','"+account.Firm_Email+"','"+account.Firm_Password + "','"+account.Firm_Address + "','"+account.Firm_City + "','" +account.Firm_State + "','" +account.Firm_PhoneNumber + "','"+account.Firm_WebPage + "','"+account.Firm_Logo + "','"+account.Firm_Signature + "','" +account.Firm_TFN + "','" +account.Firm_TransactionAccount + "','" +account.Firm_Bank + "','" + account.Firm_CityPostCode + "')";
            try
            {
                com.ExecuteNonQuery();
                con.Close();
                return View("Login");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}