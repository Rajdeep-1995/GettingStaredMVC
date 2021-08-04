using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GettingStaredMVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult login(string Username, string Password)
        {

            if (Username == "admin" && Password == "manager")
            {
                return RedirectToAction("Dashboard", "Admin"); // redirects to a particular controller and action method
            }
            else {
                return RedirectToAction("InvalidLogin");
                //if the controller is same, no need to write the name of controller
               
            }
        }

        public ActionResult InvalidLogin() {
            return View();
        }
    }
}