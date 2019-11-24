using restaurante.domain;

namespace restaurante.repository.Interfaces
{
    public interface IRestauranteRepository : IBaseRepository<Restaurante>
    {
        int GetByID(int id);
    }
}