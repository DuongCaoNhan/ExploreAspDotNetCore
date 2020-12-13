using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }

        // public IActionResult Index()
        // {
        //     return View();
        // }

        // public IActionResult Privacy()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }

        //TodoAction
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] //method sau day chi su dung cho GET request.
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]// method sau day chi su ly POST request.
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid) //ModelState do base controler cung cap
                                    //chua thong tin chi tiet va ket qua ve qua trinh rang buoc cua Model
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }

        // Do khong co chi dinh ten view nen Razor se render the defaut view, dung ten action method lam ten Views file 
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}
