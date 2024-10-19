using ConstructionMVC.Data;
using ConstructionMVC.Models;

namespace ConstructionMVC.Repository
{
	public class FornecedorRepository : IFornecedorRepository
	{
		private readonly ConstructionDbContext _context;

		public FornecedorRepository(ConstructionDbContext context)
        {
			_context = context;
        }

        public FornecedorModel Adicionar(FornecedorModel fornecedor)
		{
			_context.Fornecedores.Add(fornecedor);
			_context.SaveChanges();
			return fornecedor;
		}

        public List<FornecedorModel> ListarTodos()
        {
            return _context.Fornecedores.ToList();
        }
    }
}
