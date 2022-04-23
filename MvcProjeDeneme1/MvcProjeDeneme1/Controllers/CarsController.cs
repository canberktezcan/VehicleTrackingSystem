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
    public class CarsController : Controller
    {
        CarsManager cm = new CarsManager(new EfCarDal());
        [HttpGet]
        public ActionResult GetListCar()
        {
            string s = (string)Session["CustomerUsername"];
            var carlist = cm.GetListCar(s);
            int carID = Convert.ToInt32(carlist[0].id);
            var carvalues = cm.GetListCustomerCar1(carID);

            int carID2 = Convert.ToInt32(carlist[1].id);
            var car2values = cm.GetListCustomerCar2(carID2);
            carvalues.AddRange(car2values);
            return View(carvalues);

            // string s = (string)Session["CustomerUsername"];


            // var carvalues = cm.GetListCar(s);



            // int carID = Convert.ToInt32(cm.getCarsID(s).id);


            //// var carvalues = cm.GetListCustomerCar1(carID);
            // return View(carvalues);
            // // var carvalues = cm.
            // // return View(carvalues);
        }
        [HttpPost]
        public ActionResult GetListCar(Cars P)
        {
            string s = (string)Session["CustomerUsername"];
            var carlist = cm.GetListCar(s);
            int carID = Convert.ToInt32(carlist[0].id);
            var year = Request["year"];
            var yearson = Request["yearson"];

            DateTime dt = DateTime.ParseExact(year, "yyyy-MM-dd HH:mm", null);
            DateTime dt2 = DateTime.ParseExact(yearson, "yyyy-MM-dd HH:mm", null);

            var carvalues = cm.DateTimeBolme(carID, dt, dt2);
            int carID2 = Convert.ToInt32(carlist[1].id);
            var car2values = cm.DateTimeBolme(carID2,dt,dt2);
            carvalues.AddRange(car2values);

            //var carvalues = cm.GetListCustomerCar1(carID);

            //int carID2 = Convert.ToInt32(carlist[1].id);
            //var car2values = cm.GetListCustomerCar2(carID2);
            //carvalues.AddRange(car2values);
            //return View(carvalues);
            return View(carvalues);

        }

        [HttpGet]
        public ActionResult getListCustomerCar1()
        {

            string s = (string)Session["CustomerUsername"];
            var carlist = cm.GetListCar(s);
            int carID = Convert.ToInt32(carlist[0].id);
            var carvalues = cm.GetListCustomerCar1(carID);
            return View(carvalues);

            //string s = (string)Session["CustomerUsername"];

            //int carID = Convert.ToInt32(cm.getCarsID(s).id);


            //var carvalues = cm.GetListCustomerCar1(carID);
            //return View(carvalues);
        }


        [HttpPost]
        public ActionResult getListCustomerCar1(List<Cars> p)
        {

            string s = (string)Session["CustomerUsername"];
            var carlist = cm.GetListCar(s);
            int carID = Convert.ToInt32(carlist[0].id);
            //var carvalues = cm.GetListCustomerCar1(carID);
            //return View(carvalues);

            var year = Request["year"];
            var yearson = Request["yearson"];

            DateTime dt = DateTime.ParseExact(year, "yyyy-MM-dd HH:mm", null);
            DateTime dt2 = DateTime.ParseExact(yearson, "yyyy-MM-dd HH:mm", null);

            var carvalues = cm.DateTimeBolme(carID, dt, dt2);


            //return View(carvalues);
            // return RedirectToAction("getListCustomerCar2",carvalues);

            return View(carvalues);

            //string s = (string)Session["CustomerUsername"];
            //int carID = Convert.ToInt32(cm.getCarsID(s).id);
            //var carvalues = cm.GetListCustomerCar1(carID);
            //return View(carvalues);
        }
        [HttpGet]
        public ActionResult getListCustomerCar2()
        {

            string s = (string)Session["CustomerUsername"];
            var carlist = cm.GetListCar(s);
            int carID = Convert.ToInt32(carlist[1].id);
           
            //var year = Request["year"];
            //var yearson = Request["yearson"];

            //string iString = "2005-05-05 22:12 PM";
            //DateTime oDate = DateTime.ParseExact(iString, "yyyy-MM-dd HH:mm tt", null);
            //DateTime dt = DateTime.ParseExact(year, "yyyy-MM-dd HH:mm", null);
            //DateTime dt2 = DateTime.ParseExact(yearson, "yyyy-MM-dd HH:mm", null);

            var carvalues = cm.GetListCustomerCar2(carID);

            return View(carvalues);
            // return RedirectToAction("getListCustomerCar2",carvalues);

          //  return RedirectToAction("getListCustomerCar2", carvalues);



           // var carvalues = cm.GetListCustomerCar2(carID);
           // return View(carvalues);

            //string s = (string)Session["CustomerUsername"];

            //int carID = Convert.ToInt32(cm.getCarsID(s).id);


            //var carvalues = cm.GetListCustomerCar1(carID);
            //return View(carvalues);
        }
        [HttpPost]
        public ActionResult getListCustomerCar2(Cars p)
        {

            string s = (string)Session["CustomerUsername"];
            var carlist = cm.GetListCar(s);
            int carID = Convert.ToInt32(carlist[1].id);

            

            var year = Request["year"];
            var yearson =Request["yearson"];
         

            //string iString = "2005-05-05 22:12 PM";
            //DateTime oDate = DateTime.ParseExact(iString, "yyyy-MM-dd HH:mm tt", null);




            DateTime dt = DateTime.ParseExact(year, "yyyy-MM-dd HH:mm", null);
            DateTime dt2 = DateTime.ParseExact(yearson, "yyyy-MM-dd HH:mm", null);

            var carvalues = cm.DateTimeBolme(carID, dt,dt2);


            //return View(carvalues);
            // return RedirectToAction("getListCustomerCar2",carvalues);
          
            return View(carvalues);

        }

        public ActionResult dateTimeBolme()
        {
            string s = (string)Session["CustomerUsername"];
            var carlist = cm.GetListCar(s);
            int carID = Convert.ToInt32(carlist[0].id);
            //var carvalues = cm.DateTimeBolme(carID, 2);
            //var hourvalues = carvalues[0].dateTime.Split(' ');
           // ViewBag.date = carvalues[0].dateTime;
            return View();


        }

    }
}