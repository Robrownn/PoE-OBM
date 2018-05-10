using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PoE_OBM.Models;
using PoE_OBM.Services;

namespace PoE_OBM.Controllers
{
    [Authorize]
    public class BuildController : Controller
    {
        private readonly IBuildData _buildData;

        public BuildController(IBuildData buildData)
        {
            _buildData = buildData;
        }
        public IActionResult Index()
        {
            // Should the index view be a list of all the builds for the currently logged in user
            // or should it be a generic page that has some stuff(????) in it and the user has to navigate to their build list
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
                _buildData.Add(model);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return RedirectToAction(nameof(CreateNewBuild));
            }
        }
    }
}