using ConstructionMVC.Data;
using ConstructionMVC.Models;
using SQLitePCL;

namespace ConstructionMVC.Repository
{
    public class ObraRepository : IObraRepository
    {
        private readonly ConstructionDbContext _context;

        public ObraRepository(ConstructionDbContext context)
        {
            _context = context;    
        }

        public ObraModel Criar(ObraModel obraModel)
        {
            
            _context.Obras.Add(obraModel);
            _context.SaveChanges();
            return obraModel;
        }

        public ObraModel Editar(ObraModel obraModel)
        {
            _context.Obras.Update(obraModel);
            _context.SaveChanges();
            return obraModel;
        }

        public void Excluir(ObraModel obraModel)
        {
            _context.Obras.Remove(obraModel);
            _context.SaveChanges();
        }

		public ObraModel ListarById(int id)
		{
			return _context.Obras.FirstOrDefault(o => o.Id == id); 
		}

		public List<ObraModel> ListarTodos()
        {
            return _context.Obras.ToList();
        }

		
	}
}
