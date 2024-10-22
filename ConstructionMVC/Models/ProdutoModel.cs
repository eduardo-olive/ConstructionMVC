using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConstructionMVC.Models
{
	public class ProdutoModel
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "O Campo {0} é de preenchimento obigatório.")]
		public string Nome { get; set; }
		[Display(Name = "Descrição")]
		public string Descricao { get; set; }

		public float Unidade { get; set; }

		[Column(TypeName = "decimal(10,2)")]
		public float Peso { get; set; }

		[Required]
		[Display(Name = "Fornecedor")]
		public int IdFornecedor { get; set; }

		[ForeignKey("Id")]
		public FornecedorModel Fornecedor { get; set; }

		[Required]
		[Display(Name = "Categoria")]
		public int IdCategoria { get; set; }

		[ForeignKey("Id")]
		public CategoriaModel Categoria { get; set; }
	}
}
