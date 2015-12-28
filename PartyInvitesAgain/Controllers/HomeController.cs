using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvitesAgain.Controllers
{
    public class HomeController : Controller
    {

    /*public string Index()
        {
            return "Can return string directly into View!";
        }*/
        // GET: Home
        public ViewResult Index() {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning," : "Good afternoon,";
            return View();
        }
    }
}