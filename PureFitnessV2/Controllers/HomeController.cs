using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PureFitnessV2.Models;

namespace PureFitnessV2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // for logging
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /* 
        [HttpPost]
        [HttpGet]
        [HttpDelete]
        [HttpHead]
        [HttpOptions]
        [HttpPatch]
        [HttpPut]
        */

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CreateProfile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProfile(CreateProfileModel createProfile)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
