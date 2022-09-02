using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUPSmartBuilding.Controllers
{
    public class CommunicationController : Controller
    {
        public IActionResult Chat()
        {
            return View();
        }
        public IActionResult Homepage()
        {
            return View();
        }
    }
}
