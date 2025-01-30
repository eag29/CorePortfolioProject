using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            var values = _context.Portfolios.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio)
        {
            _context.Portfolios.Add(portfolio);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeletePortfolio(int id)
        {
            var deletedValue = _context.Portfolios.Find(id);
            _context.Portfolios.Remove(deletedValue);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UpdatePortfolio(int id)
        {
            var updatedValue = _context.Portfolios.Find(id);
            _context.Portfolios.Update(updatedValue);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
