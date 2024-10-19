using ConstructionMVC.Models;

namespace ConstructionMVC.Repository
{
	public interface IFornecedorRepository
	{
		List<FornecedorModel> ListarTodos();
		FornecedorModel Adicionar(FornecedorModel fornecedor);
		FornecedorModel Editar(FornecedorModel fornecedor);
		FornecedorModel ListarById(int id);
		void Apagar(FornecedorModel fornecedor);
	}
}
