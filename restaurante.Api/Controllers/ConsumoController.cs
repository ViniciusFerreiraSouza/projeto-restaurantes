using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Proj.Repository.Interfaces;
using Proj.Domain.Entities;

namespace note.Documents.Trabalhos_e_textos.Dotnet.ProjetoRestaurantes.projeto_restaurantes.restaurante.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumoController : ControllerBase
    {
        private IConsumoRepository repository;
        private IRestauranteRepository restauranteRepository;

        public ConsumoController(IConsumoRepository repository, IRestauranteRepository restauranteRepository)
        {
            this.repository = repository;
            this.restauranteRepository = restauranteRepository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Consumo>> Get()
        {
            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = repository.GetAll()
            });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Consumo> Get(int id)
        {
            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = repository.GetByID(id)
            });
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Consumo entity)
        {
            var restaurante = restauranteRepository.GetByID(entity.id);

            if (restaurante != null)
                entity.restaurante = restaurante;

            repository.Create(entity);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = entity
            });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Consumo entity)
        {
            var restaurante = restauranteRepository.GetByID(entity.id);

            if (restaurante != null)
                entity.restaurante = restaurante;

            repository.Update(entity);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = entity
            });
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            repository.Delete(id);
            
            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = new { }
            });
        }
    }
}