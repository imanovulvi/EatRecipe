using Appilacation.EatRecipe.Repostarys;
using Domen.EatRecipe.Entitys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence.EatRecipe.Repostarys;
using System.Diagnostics;
using WebApp.EatRecipe.Models;

namespace WebApp.EatRecipe.Controllers
{
    public class HomeController : Controller
    {
        readonly IMenuReadRepostary _context;

        public HomeController(IMenuReadRepostary context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        
    }
}
