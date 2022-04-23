using BuisnessLayerr.Concrete;
using DataAccessLayerr.EntityFramework;
using EntityLaayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeDeneme1.Controllers
{
    public class GateController : Controller
    {
        // GET: Gate
        GateManager gm = new GateManager(new EfGateDal());
        GateManager gmc = new GateManager(new EfCarDal());
        CarsManager cm = new CarsManager(new EfCarDal());

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getGateList()
        {
            CsvReadManager csvReadManager = new CsvReadManager();
            var s = csvReadManager.getCarList();
           // var gatevalues = gm.GetList();
            return View(s); 
        }


        public ActionResult getListCar()
        {
            
            var carvalues = gmc.GetListCar();
            return View(carvalues);
        }


        public ActionResult getListCustomerCar1()
        {

            //string s = (string) Session["CustomerUsername"];

            //string carID = cm.getCarsID(s).id;


            //var carvalues = gmc.GetListCustomerCar1(carID);
            //return View(carvalues);


            string s = (string)Session["CustomerUsername"];

            int carID = Convert.ToInt32(cm.getCarsID(s).id);


            var carvalues = cm.GetListCustomerCar1(carID);
            return View(carvalues);



        }



        public ActionResult getListCustomerCar2()
        {
            var carvalues = gmc.GetListCustomerCar2();
            return View(carvalues);

        }



        public JsonResult GetMapMarker()
        {
            var ListOfAddress = gm.GetList();
            return Json(ListOfAddress, JsonRequestBehavior.AllowGet);
        }
        //public ActionResult AddCar()
        //{
        //    Cars car = new Cars
        //    {
        //        id = "1",
        //        lat = "40.42568",
        //        lng = "28.3275813",
        //        dateTime = DateTime.Now.ToString("yyyy-mm-dd HH:mm")
        //    };
        //    // gm.ConnecttoMongoDB();
        //    gm.CarAdd(car);
        //    return View();
        //}


    }
}