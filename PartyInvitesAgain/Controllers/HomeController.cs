using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvitesAgain.Models;

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

        [HttpGet]
        public ViewResult RsvpForm() {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) {
            if (ModelState.IsValid) {
                //TODO: E-mail response to party planner
                return View("Thanks", guestResponse);
            } else {
                //there is a validation error
                return View();
            }
        }
    }
}