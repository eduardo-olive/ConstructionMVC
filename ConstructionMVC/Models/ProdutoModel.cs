namespace ConstructionMVC.Models
{
	public class ProdutoModel
	{
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Unidade { get; set; }
        public float Peso { get; set; }
        public int IdCategoria { get; set; }
    }
}
