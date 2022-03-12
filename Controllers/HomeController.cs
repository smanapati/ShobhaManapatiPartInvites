using Microsoft.AspNetCore.Mvc;
using ShobhaManapatiPartInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShobhaManapatiPartInvites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }

        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}
