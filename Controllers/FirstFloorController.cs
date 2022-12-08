using Microsoft.AspNetCore.Http;
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
    public class FirstFloorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
