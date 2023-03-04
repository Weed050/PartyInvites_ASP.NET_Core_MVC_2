using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;


namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {



        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.greeting = hour < 17 ? "Dzień dobry" : "Dobry wieczór";
            return View("MyView");
        }
       
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) {
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
        }
    }
}