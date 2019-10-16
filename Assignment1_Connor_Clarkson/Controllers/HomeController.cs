using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1_Connor_Clarkson.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_Connor_Clarkson.View.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RequestForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RequestForm(Request response)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(response);
                return View("Confirmation", response);
            }
            else
            {
                return View();
            }

        }

    }
}