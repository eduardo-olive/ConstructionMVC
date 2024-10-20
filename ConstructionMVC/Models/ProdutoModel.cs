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
        
        public string Descricao { get; set; }
        
        public float Unidade { get; set; }
        
        public float Peso { get; set; }
        
        [Required]
        [ForeignKey(nameof(Fornecedor))]
        public int IdFornecedor { get; set; }
        
        public FornecedorModel Fornecedor { get; set; }
        
        [Required]
        [ForeignKey(nameof(Categoria))]
        public int IdCategoria { get; set; }
		
        public CategoriaModel Categoria { get; set; }
    }
}
