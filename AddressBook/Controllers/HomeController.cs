using System;
using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    public class HomeController :  Controller
    {
        public IActionResult Index(string name)
        {
            
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}