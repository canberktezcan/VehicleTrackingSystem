using BuisnessLayerr.Concrete;
using CsvHelper;
using EntityLaayer.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeDeneme1.Controllers
{
    public class CsvReadController : Controller
    {
        //CsvReadManager cm = new CsvReadManager();
        // GET: CsvRead
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CsvRead()
        {
            CsvReadManager cm = new CsvReadManager();
            var carsvalues = cm.getCarList();
            return View(carsvalues);
        }
    }
}