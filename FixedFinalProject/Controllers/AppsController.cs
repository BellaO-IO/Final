using FixedFinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FixedFinalProject.Controllers
{
    public class AppsController : Controller
    {
        private readonly IAPIControls repo;

        public AppsController(IAPIControls repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {

            var apps = repo.GetAllApps();
            return View(apps);
        }
    }
}
