using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Linq;

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
            if (ModelState.IsValid)
            {
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
            }
            else
            {
                //error of control correct data
                return View();  
            }
        }
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}