using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CrudOperations
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");  //for ignoring the extra paths which occur while run time

            routes.MapMvcAttributeRoutes(); //to tell this file that we ll use attribute routing in our project.we can even define it in global.asax file

            //traditional routings 
            //routes.MapRoute(
            //    name:"allStudents",
            //    url:"students",  //which we will send through our url
            //    defaults:new { Controller = "Student",Action="GetAllStudent", id=1}
            //);
            //routes.MapRoute(
            //    name : "student",
            //    url:"students/{id}", //dynamic property is written like this.
            //    defaults: new {Controller = "Student", Action="GetSingleStudent"}
            //);
            //routes.MapRoute(
            //    name:"studentAddress",
            //    url:"students/{id}/Address",
            //    defaults: new {controller ="Student", Action="GetStudentAddress"},
            //    constraints: new {id = @"\d+"}
            //);
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
