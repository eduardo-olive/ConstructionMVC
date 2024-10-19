using ConstructionMVC.Controllers;
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

		public FornecedorModel ListarById(int id)
		{
			FornecedorModel fornecedor = _context.Fornecedores.FirstOrDefault(f => f.Id == id);
			return fornecedor;
		}

		public FornecedorModel Editar(FornecedorModel fornecedor)
		{
			_context.Fornecedores.Update(fornecedor);
			_context.SaveChanges();
			return fornecedor;
		}

		public void Apagar(FornecedorModel fornecedor)
		{
			_context.Fornecedores.Remove(fornecedor);
			_context.SaveChanges();
		}
	}
}
