using Appilacation.EatRecipe.Repostarys;
using Domen.EatRecipe.Entitys;
using Microsoft.AspNetCore.Mvc;
using WebApp.EatRecipe.Models.ModelViews;

namespace WebApp.EatRecipe.Areas.Admin_Panel.Controllers
{
    [Area("Admin_Panel")]

    public class PageController : Controller
    {
        readonly IPageWriteRepostary _writecontext;
        readonly IPageReadRepostary _readcontext;
        public PageController(IPageWriteRepostary writecontext, IPageReadRepostary readcontext)
        {
            _writecontext = writecontext;
            _readcontext = readcontext;
        }

        public IActionResult GetList()
        {
            var list=_readcontext.GetAll(false).ToList();
            return View(list);
        }
       
        public async Task<IActionResult> GetUpdate(int id)
        {
            Page p=await _readcontext.GetSingleAsync(x => x.Id == id);
            
            return View(p);
        }
        [HttpPost]
        public IActionResult GetUpdate(Page page)
        {
            _writecontext.Update(page);
            _writecontext.SaveChangeAsync();

            return Redirect("/admin_panel/Page/GetList");
        }

        public async Task<IActionResult> GetDeleted(int id)
        {
            _writecontext.Remove(await _readcontext.GetSingleAsync(x=>x.Id==id));
            _writecontext.SaveChangeAsync();

            return Redirect("/admin_panel/Page/GetList");
        }

        public IActionResult GetAdd()
        => View(new Page());

        [HttpPost]
        public async Task<IActionResult> GetAdd(PageAddModelView page)
        {
           await _writecontext.AddAsync(page);
           await _writecontext.SaveChangeAsync();
            return Redirect("/admin_panel/Page/GetList");
        }

    }
}
