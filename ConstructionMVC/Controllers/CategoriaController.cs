using ConstructionMVC.Models;
using ConstructionMVC.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ConstructionMVC.Controllers
{
	public class CategoriaController : Controller
	{
		private readonly ICategoriaRepository _categoriaRepository;

		public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult Index()
		{
			List<CategoriaModel> categorias = _categoriaRepository.ListarTodos();
			return View(categorias);
		}

		public IActionResult Criar()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Criar(CategoriaModel categoria)
		{
			if (ModelState.IsValid)
			{
                _categoriaRepository.Criar(categoria);
				return RedirectToAction("Index");
            }
            return View(categoria);
		}

		public IActionResult Editar(int id)
		{
			CategoriaModel categoria = _categoriaRepository.ListarById(id);
			return View(categoria);
		}

		[HttpPost]
		public IActionResult Editar(CategoriaModel categoria)
		{
			if (ModelState.IsValid)
			{
                CategoriaModel fornecedorModel = _categoriaRepository.Editar(categoria);
				return RedirectToAction("Index");
            }
			return View(categoria);
			
		}

		public IActionResult Apagar(CategoriaModel categoria)
		{
			_categoriaRepository.Excluir(categoria);
			return RedirectToAction("Index");
		}
	}
}
