using System.Collections.Generic;

namespace restaurante.repository.Interfaces
{
    where Entity : class
    {
        void Create(Entity obj);

        List<Entity> GetAll();

        void Update(Entity obj);

        Entity GetById(int id);

        void Delete(int id);
    }
}        