using Microsoft.AspNetCore.Mvc;

namespace ConstructionMVC.Controllers
{
    public class Fornecedor : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPut]
        public IActionResult Edit()
        {
            return View();
        }
    }
}
