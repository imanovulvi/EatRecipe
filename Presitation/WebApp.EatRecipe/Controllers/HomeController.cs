using Appilacation.EatRecipe.Repostarys;
using Microsoft.AspNetCore.Mvc;
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
            _context.GetAll().ToList();

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        
    }
}
