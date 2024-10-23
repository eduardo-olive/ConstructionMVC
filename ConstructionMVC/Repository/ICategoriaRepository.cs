using ConstructionMVC.Models;

namespace ConstructionMVC.Repository
{
	public interface ICategoriaRepository
	{
		List<CategoriaModel> ListarTodos();

		CategoriaModel ListarById(int id);

		CategoriaModel Criar(CategoriaModel categoriaModel);

		CategoriaModel Editar(CategoriaModel categoriaModel);

		void Excluir(CategoriaModel categoriaModel);
	}
}
