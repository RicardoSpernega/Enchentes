using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoTCC.Repositories;

namespace ProjetoTCC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICondicaoDoTempoRepository condicaoDoTempoRepository;
        public HomeController(ICondicaoDoTempoRepository condicaoDoTempoRepository)
        {
            this.condicaoDoTempoRepository = condicaoDoTempoRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Condicoes = condicaoDoTempoRepository.GetCondicaoDoTempo();
            return View();
        }
    }
}