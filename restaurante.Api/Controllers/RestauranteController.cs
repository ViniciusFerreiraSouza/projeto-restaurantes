using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Proj.Repository.Interfaces;
using Proj.Domain.Entities;

namespace note.Documents.Trabalhos_e_textos.Dotnet.ProjetoRestaurantes.projeto_restaurantes.restaurante.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestauranteController : ControllerBase
    {
        private IRestauranteRepository repository;

        public RestauranteController(IRestauranteRepository repository)
        {
            this.repository = repository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Restaurante>> Get()
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
        public ActionResult<Restaurante> Get(int id)
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
        public ActionResult Post([FromBody] Restaurante entity)
        {
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
        public ActionResult Put(int id, [FromBody] Restaurante entity)
        {
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