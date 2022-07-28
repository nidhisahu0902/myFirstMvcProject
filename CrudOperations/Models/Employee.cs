using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CrudOperations.Models
{
    public class Employee
    {
        //defining property for sending it to the controller
        public int id { get; set; }

        [Display(Name = "please display your name :")]
        public string name { get; set; }

     
        public string address { get; set; }

        [DataType(DataType.Date)]
        public DateTime date { get; set; }
    }
}