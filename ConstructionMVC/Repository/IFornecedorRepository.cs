using ConstructionMVC.Models;

namespace ConstructionMVC.Repository
{
	public interface IFornecedorRepository
	{
		List<FornecedorModel> ListarTodos();
		FornecedorModel Adicionar(FornecedorModel fornecedor);
	}
}
