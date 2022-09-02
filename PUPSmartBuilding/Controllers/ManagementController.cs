using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUPSmartBuilding.Controllers
{
    public class ManagementController : Controller
    {
        public IActionResult User()
        {
            return View();
        }
        public IActionResult newUser()
        {
            return View();
        }
    }
}
