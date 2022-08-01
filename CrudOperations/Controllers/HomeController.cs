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
            ViewBag.MyCustomProp = "View bag is is used to send dynamic data from controller to view";
            ViewBag.list1 = new List<string>() {"n","k"};

            //for creating viewbag for the dynamic property of model employee
            List<Employee> empList = new List<Employee>()
            {
                    new Employee(){name ="n",address="udaipur" },
                    new Employee(){name ="k",address="udaipur1" }


            };
            ViewBag.myNewList = empList;
            //for creating viewbag for the dynamic property of model employee

            //for creating view data
            ViewData["MyKey"] = "This is view data";
            ViewData["MySecondKey"] = new List<string>() { "n1", "k1" };
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
           // Console.WriteLine(emp);
            return View();
        }

        public ActionResult edit()
        {
            return View();
        }
    }
} 