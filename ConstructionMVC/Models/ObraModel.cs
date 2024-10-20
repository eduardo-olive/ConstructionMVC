using System.ComponentModel.DataAnnotations;

namespace ConstructionMVC.Models
{
	public class ObraModel
	{
		[Key]
		[Display(Name = "Código")]
		[DisplayFormat(DataFormatString = "{0:D5}")]
		public int Id { get; set; }
		
		[Required(ErrorMessage = "O Campo {0} é de preenchimento obrigatório.")]
		[Display(Name = "Nome da Obra")]
		[MaxLength(100)]
		public string Nome { get; set; }
		
		[MaxLength(500)]
		[Display(Name = "Descrição da Obra")]
		public string Descricao { get; set; }
		
		[Required(ErrorMessage = "O Campo {0} é de preenchimento obrigatório")]
		[Display(Name = "Endereço")]
		public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Responsavel { get; set; }
    }
}
