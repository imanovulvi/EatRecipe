﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp.EatRecipe.Areas.Admin_Panel.Controllers
{
    [Area("Admin_Panel")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
