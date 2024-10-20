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

        public IActionResult Index()
		{
			List<ObraModel> obras = _obraRepository.ListarTodos();
			return View(obras);
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
