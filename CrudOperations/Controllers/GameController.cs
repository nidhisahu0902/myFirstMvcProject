using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudOperations.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
         /*public string Name()
        {
            return "Nidhi";
        }*/

        public string FullName(string fName , string     lName = null)
        {
            return "First name is:" + fName + " Last Name is :" + lName; 
        }
    }
}