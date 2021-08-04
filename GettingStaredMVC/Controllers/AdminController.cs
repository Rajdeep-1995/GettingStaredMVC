using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GettingStaredMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult DashBoard()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.contact = "456-456-4567";
            return View();
        }
    }
}