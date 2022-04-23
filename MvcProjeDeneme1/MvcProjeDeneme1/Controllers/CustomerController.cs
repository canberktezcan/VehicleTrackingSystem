using BuisnessLayerr.Concrete;
using DataAccessLayerr.EntityFramework;
using EntityLaayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcProjeDeneme1.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager cm = new CustomerManager(new EfCustomerDal());


        public ActionResult Index()
        {
            var CustomerValues = cm.GetList();
            return View(CustomerValues);
        }

      
       

    }
}
