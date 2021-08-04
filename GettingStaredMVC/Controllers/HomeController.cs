using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GettingStaredMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View("ourCompanyProducts");
        }

        public ActionResult Contact()
        {
            ViewBag.contact = "123-123-1234";
            return View();
        }

        // to return string type content 
        public ActionResult EmpName(int empId)
        {
            var employees = new[] {
                new{empId=1,empName="Scott",Salary=10000 },
                 new{empId=2,empName="John",Salary=20000 },
                  new{empId=3,empName="Doe",Salary=30000 }
            };

            string MatchEmpName = null;

            foreach(var itme in employees) {
                if (itme.empId == empId) {
                    MatchEmpName = itme.empName;
                }
            }

            //return new ContentResult() { Content = MatchEmpName, ContentType = "text/plain" };
            return Content(MatchEmpName, "text/plain");
        }

        public ActionResult GetPassportSlip(int PassId) {

            var fileName = "~/passport" + PassId + ".pdf";

            return File(fileName, "application/pdf"); // this will send the entire document in the browser
        
        }


        //the benefit of using action result is we can send files, strings, json, views anything
        public ActionResult redirectEmp(int empId) {

            string fbUrl = null;
            var employees = new[] {
                new{empId=1,empName="Scott",Salary=10000 },
                 new{empId=2,empName="John",Salary=20000 },
                  new{empId=3,empName="Doe",Salary=30000 }
        };

            

            foreach (var itme in employees)
            {
                if (itme.empId == empId)
                {
                    fbUrl = "http://www.facbook.com/emp" + empId;
                }
            }

            if (fbUrl == null) {
                return Content("Invalid emp Id");
            }
            else
            {
                return Redirect(fbUrl);
            }

        }

        public ActionResult studentInfo()
        {
            ViewBag.stdId = 1;
            ViewBag.stdName = "John";
            ViewBag.stdMarks = 87;
            ViewBag.numberOfSem = 6;
            ViewBag.subjects = new List<string> { "Physics", "Chemestry", "Mathemetics" };

            return View();

        }

        public ActionResult RequestObject()
        {
            ViewBag.Url = Request.Url;
            ViewBag.PhysicalAppliactionPath = Request.PhysicalApplicationPath;
            ViewBag.Path = Request.Path;
            ViewBag.BrowserType = Request.Browser.Type;
            ViewBag.QueryString = Request.QueryString["n"];
            ViewBag.Header = Request.Headers["Accept"];
            ViewBag.HttpMehod = Request.HttpMethod;
            return View();
        }

        public ActionResult ResponseObject()
        {
            Response.Write("Hello World!");
            Response.ContentType = "text/plain"; // default is "text/html"
            Response.Headers["Server"] = "My Server";
            Response.StatusCode = 500;
            
            return View();
        }
    }
}