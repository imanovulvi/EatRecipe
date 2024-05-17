using Appilacation.EatRecipe.Repostarys;
using Domen.EatRecipe.Entitys;
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
           List<Menu> aaa= _context.GetAll().OrderBy(x =>x.Row).OrderBy(x=>x.DownMenu).ToList();

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        
    }
}
