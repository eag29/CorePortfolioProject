using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        Context _context = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount = _context.ToDoLists.Where(x => x.Status == false).Count();
            var values = _context.ToDoLists.Where(x => x.Status == false).ToList();
            return View(values);
        }
    }
}
