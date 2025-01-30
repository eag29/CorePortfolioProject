using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class AboutController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            var values = _context.Abouts.ToList();
            return View(values);
        }
    }
}
