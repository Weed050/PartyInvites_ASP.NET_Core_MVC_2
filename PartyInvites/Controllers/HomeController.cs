using Microsoft.AspNetCore.Mvc;


namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {



        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 17 ? "Dzień dobry" : "Dobry wieczór";
            return View("MyView");
        }

    }
}