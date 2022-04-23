using BuisnessLayerr.Concrete;
using EntityLaayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeDeneme1.Controllers
{
    public class ExitController : Controller
    {
    
        SqlConnection conn;
        SqlCommand cmd;

        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(Customer p)
        {
            string CustomerUsername = (string)Session["CustomerUsername"];
            conn = new SqlConnection("data source=DESKTOP-UCGJN4J; initial catalog=DbMvcDeneme2; integrated security=true;");
            string sorgu = "Update Customers Set CustomerLogoutTime=@CustomerLogoutTime Where CustomerUsername=@CustomerUsername";
            cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@CustomerLogoutTime", DateTime.Now);
            cmd.Parameters.AddWithValue("@CustomerUsername", CustomerUsername);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            return RedirectToAction("Index", "Login");
        }
    }
}