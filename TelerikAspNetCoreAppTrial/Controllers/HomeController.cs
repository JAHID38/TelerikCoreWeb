using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelerikAspNetCoreAppTrial.Models;

namespace TelerikAspNetCoreAppTrial.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Test & Trial for Telerik UI";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        
        public IActionResult DateTimeUI()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View(new UserViewModel()
            {
                FirstName = "Md. Jahidul Islam",
                LastName = "Jahid",
                Email = "jahid.islam2022@outlook.com",
                UserName = "j@hid",
                Password = "123456",
                DateOfBirth = new DateTime(1990, 5, 8),
                Agree = false
            });
        }
        [HttpPost]
        public ActionResult Registration(UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                TempData["View"] = "Registration";
                return View("Success");
            }
        }


    }
}
