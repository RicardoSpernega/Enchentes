using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoTCC.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoTCC.Controllers
{
    public class PedidoController : Controller
    {
        private readonly ICondicaoDoTempoRepository condicaoDoTempoRepository;

        public PedidoController(ICondicaoDoTempoRepository condicaoDoTempoRepository)
        {
            this.condicaoDoTempoRepository = condicaoDoTempoRepository;
        }

        public IActionResult Carrossel()
        {
            return View(condicaoDoTempoRepository.GetCondicaoDoTempo());
        }
        public IActionResult Carrinho()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Resumo()
        {
            return View();
        }
    }
}