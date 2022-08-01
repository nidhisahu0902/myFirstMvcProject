using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudOperations.Controllers
{
    public class TempController : Controller
    {
        // GET: Temp
        public ActionResult Index()
        {
            TempData["myKey"] = "index 0";
       
           
            return View();
        }
        public ActionResult index2()
        {
            ViewBag.Mykey = TempData.Peek("myKey"); // to save data and read it peek is used.
            Session.Abandon(); //to close the session it will not save the value for next session
            // TempData.Keep("myKey");  //to keep the data for the next state or actionmethod this is used

            return View();
        }
        public ActionResult index3()
        {
            ViewBag.Mykey = TempData["myKey"];
            return View();
        }
    }
}