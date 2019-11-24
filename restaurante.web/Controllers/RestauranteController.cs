using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using restaurante.repository.Interfaces;
using restaurante.web.Models;

namespace restaurante.web.Controllers
{
    public class RestauranteController : Controller
    {
        private IRestauranteRepository restauranteRepository;

        public RestauranteController(IRestauranteRepository restauranteRepository)
        {
            this.restauranteRepository = restauranteRepository;
        }

        public IActionResult Index()
        {
            return View(restauranteRepository.GetAll());
        }

        public IActionResult View(int id)
        {
            return View(restauranteRepository.GetByID(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Restaurante entity)
        {
            restauranteRepository.Create(entity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(restauranteRepository.GetByID(id));
        }

        [HttpPost]
        public RedirectToActionResult Update(Restaurante entity)
        {
            restauranteRepository.Update(entity);
            return RedirectToAction("Index");
        }

        public RedirectToActionResult Delete(int id)
        {
            restauranteRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}