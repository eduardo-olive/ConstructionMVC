using ConstructionMVC.Data;
using Microsoft.EntityFrameworkCore;

namespace ConstructionMVC.Models
{
	public class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new ConstructionDbContext(
					serviceProvider.GetRequiredService<DbContextOptions<ConstructionDbContext>>()))
			{
				if(context.Fornecedores.Any())
				{
					return;
				}
				
				context.Fornecedores.AddRange(
					new FornecedorModel
					{
						RazaoSocial = "Fornecedor Teste",
						NomeFantasia = "Fornecedor",
						CNPJ = " ",
						Responsavel = "Fulano de Tal",
						Telefone = "99999999999",
						DataCadastro = DateTime.Parse("1984-3-13")
					}
				);
				context.SaveChanges();
			}
		}
	}
}
