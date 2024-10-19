using ConstructionMVC.Models;
using ConstructionMVC.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ConstructionMVC.Controllers
{
    public class Fornecedor : Controller
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public Fornecedor(IFornecedorRepository fornecedorRepository) 
        {
            _fornecedorRepository = fornecedorRepository;
        }

        
        public IActionResult Criar()
        {
           
            return View();
        }
        public IActionResult Index()
        {
			List<FornecedorModel> fornecedores = _fornecedorRepository.ListarTodos();
			return View(fornecedores);
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
        [HttpPost]
        public IActionResult Criar(FornecedorModel fornecedor)
        {
            _fornecedorRepository.Adicionar(fornecedor);
            return RedirectToAction("Index");
        }
    }
}
