using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using restaurante.domain;
using restaurante.repository.Data;
using restaurante.repository.Interfaces;

namespace restaurante.repository.Repositórios
{
    public class RestauranteRepository: IRestauranteRepository
    {
        DataContext context;

        public RestauranteRepository(DataContext context)
        {
            this.context=context;
        }
        public void Create(Restaurante obj)
        {
            context.Restaurantes.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Restaurantes.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Restaurante> GetAll()
        {
            return context.Restaurantes.ToList();
        }

        public Restaurante GetById(int id)
        {
            return context.Restaurantes.SingleOrDefault(x=>x.id==id);
        }
        
        public void Update(Restaurante obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}