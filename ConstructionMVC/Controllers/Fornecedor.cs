using Microsoft.AspNetCore.Mvc;

namespace ConstructionMVC.Controllers
{
    public class Fornecedor : Controller
    {
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Editar()
        {
            return View();
        }
        [HttpDelete]
        public IActionResult Excluir()
        {
            return View();
        }
    }
}
