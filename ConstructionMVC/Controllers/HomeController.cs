using ConstructionMVC.Data;
using ConstructionMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConstructionMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ConstructionDbContext _context;

        public HomeController(ConstructionDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string SearchString)
        {
            var obras = from o in _context.Obras 
                            select o;

            if(!String.IsNullOrEmpty(SearchString) ) { 
                obras = obras.Where(s => s.Nome!.ToUpper().Contains(SearchString.ToUpper()));
            }

            return View(obras.ToList());
        }

        public IActionResult Details(int id)
        {
            ObraModel obra = _context.Obras.FirstOrDefault(o => o.Id == id);
            return View(obra);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
