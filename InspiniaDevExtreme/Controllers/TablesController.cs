using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace InspiniaDevExtreme.Controllers
{
    public class TablesController : Controller
    {
        public IActionResult DevExtremeGrid()
        {
            return View();
        }
    }
}