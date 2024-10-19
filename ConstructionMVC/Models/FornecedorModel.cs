using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConstructionMVC.Models
{
    public class FornecedorModel
    {
        [Key]
        [DisplayName("Código")]
        [DisplayFormat(DataFormatString = "{0:D5}")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é de preenchimento obrigatório.")]
        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }

        public string? CNPJ { get; set; }

        [Required(ErrorMessage = "O Campo {0} é de preenchimento obrigatório.")]
        [DisplayName("Nome Fantasia")]
        public string? NomeFantasia { get; set; }

        public string? Responsavel { get; set; }

		[RegularExpression(@"^[0-9""'\s-]*$")]
		[MaxLength(15)]
		public string? Telefone { get; set; }
        
        [DisplayName("Data de Cadastro")]
        [DataType(DataType.Date)]
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
