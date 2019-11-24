using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using restaurante.web.Models;

namespace restaurante.web.Controllers
{
    public class ConsumoController : Controller
    {
        private IConsumoRepository consumoRepository;
        private IRestauranteRepository restauranteRepository;

        public ConsumoController(IConsumoRepository consumoRepository, IRestauranteRepository restauranteRepository)
        {
            this.consumoRepository = consumoRepository;
            this.restauranteRepository = restauranteRepository;
        }

        public IActionResult Index()
        {
            ViewBag.menorPreco = consumoRepository.GetMenorPreco();
            ViewBag.maiorPreco = consumoRepository.GetMaiorPreco();
            return View(consumoRepository.GetAll());
        }

        public IActionResult View(int id)
        {
            ViewBag.Restaurantes = restauranteRepository.GetAll();
            return View(consumoRepository.GetByID(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Restaurantes = restauranteRepository.GetAll();
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Consumo entity)
        {   //resolver problema na entidade restaurante
            entity.restaurante = restauranteRepository.GetByID(entity.restaurante.id);
            consumoRepository.Create(entity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.restaurante = restauranteRepository.GetAll();
            return View(consumoRepository.GetByID(id));
        }

        [HttpPost]
        public RedirectToActionResult Update(Consumo entity)
        {
            entity.restaurante = restauranteRepository.GetByID(entity.restaurante.id);
            consumoRepository.Update(entity);
            return RedirectToAction("Index");
        }

        public RedirectToActionResult Delete(int id)
        {
            consumoRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}