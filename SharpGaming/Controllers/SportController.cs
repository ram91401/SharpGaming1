using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpGaming.Controllers
{
    public class SportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        

    }
}
