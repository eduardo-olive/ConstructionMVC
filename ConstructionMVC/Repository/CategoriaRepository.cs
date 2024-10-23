using ConstructionMVC.Data;
using ConstructionMVC.Models;

namespace ConstructionMVC.Repository
{
	public class CategoriaRepository : ICategoriaRepository
	{
		private readonly ConstructionDbContext _context;

		public CategoriaRepository(ConstructionDbContext context)
        {
            _context = context;
        }

        public CategoriaModel Criar(CategoriaModel categoriaModel)
		{
			_context.Categorias.Add(categoriaModel);
			_context.SaveChanges();
			return categoriaModel;
		}

		public CategoriaModel Editar(CategoriaModel categoriaModel)
		{
			_context.Categorias.Update(categoriaModel);
			_context.SaveChanges();
			return categoriaModel;
		}

		public void Excluir(CategoriaModel categoriaModel)
		{
			_context.Categorias.Remove(categoriaModel);
			_context.SaveChanges();
		}

		public CategoriaModel ListarById(int id)
		{
			CategoriaModel categoria = _context.Categorias.FirstOrDefault(e => e.Id == id);
			return categoria;
		}

		public List<CategoriaModel> ListarTodos()
		{
			List<CategoriaModel> categorias = _context.Categorias.ToList();
			return categorias;
		}
	}
}
