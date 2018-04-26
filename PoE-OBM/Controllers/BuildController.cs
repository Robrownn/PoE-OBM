using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PoE_OBM.Models;

namespace PoE_OBM.Controllers
{
    [Authorize]
    public class BuildController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateNewBuild()
        {
            return View();
        }

        public IActionResult CreateBuild(ExileBuild model)
        {
            if (ModelState.IsValid)
            {
                // Add model to DB
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(nameof(CreateNewBuild));
            }
        }
    }
}