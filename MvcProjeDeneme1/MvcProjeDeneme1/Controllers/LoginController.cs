using BuisnessLayerr.Concrete;
using DataAccessLayerr.EntityFramework;
using EntityLaayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcProjeDeneme1.Controllers
{
    public class LoginController : Controller
    {
        CustomerLoginManager cm = new CustomerLoginManager(new EfCustomerDal());
        SqlConnection conn;
        SqlCommand cmd;
        static int denemeSayisi = 0;
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index (Customer p)
        {
           
            var Customeruserinfo = cm.GetCustomer(p.CustomerUsername, p.CustomerPassword);
            if (Customeruserinfo != null)
            {

                FormsAuthentication.SetAuthCookie(Customeruserinfo.CustomerUsername, false);
                Session["CustomerUsername"] = Customeruserinfo.CustomerUsername;
                ViewBag.user= Customeruserinfo.CustomerUsername;
                //Session.Add("Username", Customeruserinfo.CustomerUsername);
                //return RedirectToAction("GetListCar", "Gate");

                conn = new SqlConnection("data source=DESKTOP-UCGJN4J; initial catalog=DbMvcDeneme2; integrated security=true;");
                string sorgu = "Update Customers Set CustomerLoginTime=@CustomerLoginTime Where CustomerUsername=@CustomerUsername";
                cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@CustomerLoginTime",DateTime.Now);
                cmd.Parameters.AddWithValue("@CustomerUsername",Customeruserinfo.CustomerUsername);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                return RedirectToAction("Index", "Home");
            }
            else
            {
               
                denemeSayisi++;
                return View(denemeSayisi);
            }
        }
    }
}