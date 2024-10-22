using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConstructionMVC.Models
{
	public class ItemObraModel
	{
        [Key]
		public int IdObra { get; set; }
        
        [Key]
        public int IdProduto { get; set; }
        
        [Key]
        [Required]
        [Display(Name = "Data da Compra")]
        public DateTime DataCompra { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "O Campo {0} é de preenchimento obrigatório")]
        [Display(Name = "Valor Unitário")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorUnitario { get; set; }

        [Required(ErrorMessage = "O Campo {0} é de preenchimento obrigatório")]
        public float Quantidade { get; set; }
        
        [ForeignKey("IdObra")]
        public ObraModel Obra { get; set; }
        
        [ForeignKey("IdProduto")]
		public ProdutoModel Produto { get; set; }
        
    }
}
