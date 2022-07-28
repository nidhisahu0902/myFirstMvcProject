using CrudOperations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudOperations.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var data = GetEmployee();       //taking static data from getemployee function
            return View(data);              //sending data with the view
        }

        public ActionResult About(string name)
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            // ViewBag.Message = "Your contact page.";
           
            return View();
        }

        private Employee GetEmployee()   //fucntion for delcaring static data for view
        {
            return new Employee
            {
                id = 1,
                name = "Nidhi",
                address = "udaipur"
            };
        }
        //for taking form-data
        [HttpPost]
        public ActionResult index(Employee emp)
        {
            Console.WriteLine("data posted");
            return View();
        }

        public ActionResult edit()
        {
            return View();
        }
    }
} 