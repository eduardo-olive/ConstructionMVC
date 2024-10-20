using System.ComponentModel.DataAnnotations;

namespace ConstructionMVC.Models
{
	public class CategoriaModel
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage = "O Campo {0} é de preenchimento obrigatório.")]
		public string Nome { get; set; }
	}
}
