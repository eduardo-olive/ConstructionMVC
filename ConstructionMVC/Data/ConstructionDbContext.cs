using ConstructionMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ConstructionMVC.Data
{
	public class ConstructionDbContext : DbContext
	{
        public ConstructionDbContext(DbContextOptions<ConstructionDbContext> options) : base(options)
        {   
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ItemObraModel>()
				   .HasKey(e => new { e.IdObra, e.IdProduto, e.DataCompra });
		}

		public DbSet<FornecedorModel> Fornecedores { get; set; }
        public DbSet<ObraModel> Obras { get; set; }
        public DbSet<CategoriaModel> Categorias { get; set; }
        public DbSet<ProdutoModel> Produtos { get; set; }
        public DbSet<ItemObraModel> ItemsObra { get; set; }
    }
}
