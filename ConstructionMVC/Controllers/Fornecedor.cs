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
        
        public IActionResult Editar(int id)
        {
			FornecedorModel fonecedorModel = _fornecedorRepository.ListarById(id);
			return View(fonecedorModel);
		}
        
        [HttpPost]
        public IActionResult Criar(FornecedorModel fornecedor)
        {
            if (ModelState.IsValid)
            {
				_fornecedorRepository.Adicionar(fornecedor);
				return RedirectToAction("Index");
			}
            return View(fornecedor);
        }
		
        [HttpPost]
		public IActionResult Editar(FornecedorModel fornecedor)
        {
            if (ModelState.IsValid)
            {
				FornecedorModel fonecedorModel = _fornecedorRepository.Editar(fornecedor);
				return RedirectToAction("Index");
			}
            return View(fornecedor);
		}

		public IActionResult Apagar(FornecedorModel fornecedor)
        {
            _fornecedorRepository.Apagar(fornecedor);
            return RedirectToAction("Index");
        }
        
    }
}
