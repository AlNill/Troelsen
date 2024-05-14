using Microsoft.AspNetCore.Mvc;
using PartyInvites.Chapter1.Models;
using System.Diagnostics;

namespace PartyInvites.Chapter1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }

        [HttpGet]
        public IActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RsvpForm(GuestResponse response)
        {
            if(ModelState.IsValid)
            {
                Repository.AddResponse(response);
                return View("Thanks", response);
            }            
            else 
                return View();
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}