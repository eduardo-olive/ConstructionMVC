using ConstructionMVC.Models;

namespace ConstructionMVC.Repository
{
    public interface IObraRepository
    {
        List<ObraModel> ListarTodos();

        ObraModel ListarById(int id);
        
        ObraModel Criar(ObraModel obraModel);

        ObraModel Editar(ObraModel obraModel);

        void Excluir(ObraModel obraModel);
    }
}
