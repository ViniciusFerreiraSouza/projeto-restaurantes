namespace restaurante.repository.Repositórios
{
    public class RestauranteRepository: IRestauranteRepository
    {
        DataContext context;

        public RestaurantRepository(DataContext context)
        {
            this.context=context;
        }
        public void Create(Restaurante obj)
        {
            context.Restaurante.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Delete.Add(obj);
            context.SaveChanges();
        }

        public List<Restaurante> GetAll()
        {
            return context.Restaurantes.ToList();
        }

        public Restaurante GetbyId(int id)
        {
            return context.Restauramtes.SingleOrDefault(x=>x.id==id);
        }
        
        public void Update(Restaurant obj)
        {
            context.Update.Add(obj);
            context.SaveChanges();
        }
    }
}