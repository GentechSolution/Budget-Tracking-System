using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrationAndLogin.Models;

namespace RegistrationAndLogin.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }
        //displays the accomodation expense form
        public ActionResult AccomodationExpenses() 
        {
            return View();
        }
        //displays the monthly expenses form
        public ActionResult MonthlyExpenses() 
        {
            return View();
        }
        //displays the vehicle expenses form
        public ActionResult VehicleExpenses() 
        {
            return View();
        }
    }
}