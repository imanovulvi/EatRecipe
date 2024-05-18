using Appilacation.EatRecipe.Repostarys;
using Domen.EatRecipe.Entitys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;
using Persistence.EatRecipe.Context;
using Persistence.EatRecipe.Repostarys;

namespace WebApp.EatRecipe.ViewComponents
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
            IQueryable<Menu> queryMenu = _context.GetAll(false);
            List<Menu> menu = queryMenu.Include(x => x.MenuDownUps).OrderBy(x => x.Row).ToList();
            return View(menu);
          
        }

    }
}
