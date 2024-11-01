using ConstructionMVC.Models;
using ConstructionMVC.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ConstructionMVC.Controllers
{
	public class ObraController : Controller
	{
        private readonly IObraRepository _obraRepository;

        public ObraController(IObraRepository obraRepository)
        {
			_obraRepository = obraRepository;    
        }

        public IActionResult Index(string SearchString)
		{
			var obras = from o in _obraRepository.ListarTodos() 
						select o;

			if (!String.IsNullOrEmpty(SearchString))
			{
				obras = obras.Where(s => s.Nome!.ToUpper().Contains(SearchString.ToUpper()));
			}

			
			return View(obras.ToList());
		}

		public IActionResult Criar()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Criar(ObraModel obra)
		{
			if (ModelState.IsValid)
			{
				_obraRepository.Criar(obra);
				return RedirectToAction("Index");
			}
			return View(obra);
		}

		public IActionResult Editar(int id)
		{
			ObraModel obra = _obraRepository.ListarById(id);
			return View(obra);	
		}

		[HttpPost]
		public IActionResult Editar(ObraModel obra)
		{
			if (ModelState.IsValid)
			{
				_obraRepository.Editar(obra);
				return RedirectToAction("Index");
			}
			return View(obra);
		}

		public IActionResult Apagar(ObraModel obra)
		{
			_obraRepository.Excluir(obra);
			return RedirectToAction("Index");
		}
	}
}
