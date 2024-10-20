using ConstructionMVC.Data;
using ConstructionMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
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

        public IActionResult Index()
        {
            List<ObraModel> obras = _context.Obras.ToList();
            return View(obras);
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
