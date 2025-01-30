using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial: ViewComponent
    {
        Context _context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = _context.Abouts.Select(x=>x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = _context.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = _context.Abouts.Select(x=>x.Details).FirstOrDefault();
            return View();
        }
    }
}
