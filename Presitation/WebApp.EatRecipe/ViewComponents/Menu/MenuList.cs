using Appilacation.EatRecipe.Repostarys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;
using Persistence.EatRecipe.Context;
using Persistence.EatRecipe.Repostarys;

namespace WebApp.EatRecipe.ViewComponents.Menu
{
    public class MenuList : ViewComponent
    {
        readonly IMenuReadRepostary _context;

        public MenuList(IMenuReadRepostary context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menu =await  _context.GetAll().ToListAsync();
            return View(menu);
        }

    }
}
