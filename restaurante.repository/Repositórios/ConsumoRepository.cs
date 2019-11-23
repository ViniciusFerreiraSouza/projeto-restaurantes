using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using restaurante.domain;
using restaurante.repository.Data;
using restaurante.repository.Interfaces;

namespace restaurante.repository.Repositories
{
    public class ConsumoRepository : IConsumoRepository
    {
        DataContext context;

        public ConsumoRepository(DataContext context)
        {
            this.context=context;
        }
        public void Create(Consumo obj)
        {
            context.Consumos.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Consumos.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Consumo> GetAll()
        {
            return context.Consumos.Include(x=> x.restaurante).ToList();
        }

        public Consumo GetById(int id)
        {
            return context.Consumos.Include(x=>x.restaurante).SingleOrDefault(x=>x.id==id);
        }

        public void Update(Consumo obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}