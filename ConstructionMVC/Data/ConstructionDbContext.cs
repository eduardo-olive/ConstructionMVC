using ConstructionMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ConstructionMVC.Data
{
	public class ConstructionDbContext : DbContext
	{
        public ConstructionDbContext(DbContextOptions<ConstructionDbContext> options) : base(options)
        {   
        }

        public DbSet<FornecedorModel> Fornecedores { get; set; }
    }
}
