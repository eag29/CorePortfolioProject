using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            ViewBag.d1 = _context.Skills.Count();
            ViewBag.d2 = _context.Messages.Count();
            ViewBag.d3 = _context.Messages.Where(x => x.isRead == false).Count();
            ViewBag.d4 = _context.Messages.Where(x => x.isRead == true).Count();
            return View();
        }
    }
}
