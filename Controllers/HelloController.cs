using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TowerHallSimulator.Models;

namespace TowerHallSimulator.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Minnesota()
        {
            return View();
        }
        public IActionResult Wisconsin()
        {
            return View();
        }
        public IActionResult Maryland()
        {
            return View();
        }
    }
}
