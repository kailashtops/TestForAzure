using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestForAzure.Models;

namespace TestForAzure.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login() { 
         return View();
        }
        [HttpPost]
        public ActionResult Login(UserData userData)
        {
            if (userData.UserName == "kk" && userData.Password == "123")
            {
                ViewBag.msg="Welcome "+ userData.UserName;
            }
            else {
                ViewBag.msg = "Invalid Username and Password";
            }
            return View();
        }
    }
}