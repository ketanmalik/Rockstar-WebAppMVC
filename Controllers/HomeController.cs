using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using rockstar_webappmvc.Models;

namespace rockstar_webappmvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        [Route("Home/Index/{id?}")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Home/Privacy")]
        [Route("Home/Privacy/{id?}")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Home/GirlsLikeYou")]
        [Route("Home/GirlsLikeYou/{id?}")]
        public IActionResult GirlsLikeYou()
        {
            return View();
        }

        [Route("Home/SleepOnTheFloor")]
        [Route("Home/SleepOnTheFloor/{id?}")]
        public IActionResult SleepOnTheFloor()
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
