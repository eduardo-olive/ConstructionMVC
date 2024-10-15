using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConstructionMVC.Models
{
    public class Fornecedor
    {
        [Key]
        [DisplayName("Código")]
        [DisplayFormat(DataFormatString = "{0:D5}")]
        public int Id { get; set; }
        
        [Required(ErrorMessage ="O Campo {0} é de preenchimento obrigatório.")]
        public string RazaoSocial { get; set; }
        
        [Required(ErrorMessage = "O Campo {0} é de preenchimento obrigatório.")]
        public string Fantasia { get; set; }
        
        public string Responsavel { get; set; }
        
        public string Telefone { get; set; }
        
        [DisplayName("Data de Cadastro")]
        [DataType(DataType.Date)]
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
