using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudOperations.Models;

namespace CrudOperations.Controllers
{
    [RoutePrefix("Students")] //used for common prefix route in below sub routes
    public class StudentController : Controller
    {
        [Route("")]         //attribute routing
        public ActionResult GetAllStudent()
        {
            var students = Students();
            return View(students);
        }
        [Route("{id:int}")]  //same routes need to be seprated by the datatypes this is called constraints
                             //[Route("{id:int:min(5)}")]   //min is used to set the minimum value of the id    
        public ActionResult GetSingleStudent(int id)
        {
            var student = Students().FirstOrDefault(x=>x.Id == id);
            return View(student);
        }

        [Route("{id}/address")]
        public ActionResult GetStudentAddress(int id)
        {
            var studentAddress = Students().Where(x => x.Id == id).Select(x => x.Address).FirstOrDefault();
            return View(studentAddress);
        }
        [Route("{id}")]
        public string Mystring(string id)
        {
            return id;
        }
        [Route("~/about-us")]  //use tild sign to override the common route "students"
        [Route("aboutus")]
        public string AboutUs()
        {
            return "this is about us";
        }
        private List<Student> Students() => new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "nidhi sahu",
                    Class = "first",
                    Address = new Address()
                    {
                        Address1 = "1111",
                        City = "ud",
                        HomeNumber ="stu1"
                    }
                },
                   new Student()
                {
                    Id = 2,
                    Name = "Bhavesh Goswami",
                    Class = "first",
                    Address = new Address()
                    {
                        Address1 = "1112",
                        City = "aj",
                        HomeNumber ="stu2"
                    }
                },
                         new Student()
                {
                    Id = 3,
                    Name = "Niru Bhati",
                    Class = "second",
                    Address = new Address()
                    {
                        Address1 = "1113",
                        City = "aj",
                        HomeNumber ="stu3"
                    }
                },
                               new Student()
                {
                    Id = 3,
                    Name = "Neha Choubisa",
                    Class = "third",
                    Address = new Address()
                    {
                        Address1 = "1113",
                        City = "ajk",
                        HomeNumber ="stu3"
                    }
                },
                                     new Student()
                {
                    Id = 4,
                    Name = "Bharat ",
                    Class = "fourth",
                    Address = new Address()
                    {
                        Address1 = "1113",
                        City = "sirohi",
                        HomeNumber ="stu4"
                    }
                },
            };
    }
}