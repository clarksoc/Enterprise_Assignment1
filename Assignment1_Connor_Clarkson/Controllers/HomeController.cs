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
                return View("Confirmation");
            }
            else
            {
                return View();
            }

        }
        public IActionResult AllEquipment()
        {
            return View();
        }
        public IActionResult AvailableEquipment()
        {
            return View();
        }
        public IActionResult Requests()
        {
            return View();
        }

        public IActionResult RequestDetails()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RequestDetails(int id)
        {

            var request = (Repository.ListRequests.Find(r => r.Id == id));
            if (request == null)
            {
                return View("Index");
            }
            return View(request);
        }
    }
}