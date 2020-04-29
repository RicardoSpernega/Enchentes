using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using ProjetoTCC.Models.ModelXML;
using ProjetoTCC.Repositories;

namespace ProjetoTCC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICondicaoDoTempoRepository condicaoDoTempoRepository;
        private string url = "http://servicos.cptec.inpe.br/XML/cidade/7dias/4749/previsao.xml";
        public HomeController(ICondicaoDoTempoRepository condicaoDoTempoRepository)
        {
            this.condicaoDoTempoRepository = condicaoDoTempoRepository;
        }

        public IActionResult Index()
        {
            XmlSerializer ser = new XmlSerializer(typeof(Cidades));

            WebClient client = new WebClient();

            string data = Encoding.Default.GetString(client.DownloadData(url));

            Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(data));

            Cidades reply = (Cidades)ser.Deserialize(stream);
            ViewBag.Condicoes = condicaoDoTempoRepository.GetCondicaoDoTempo();
            return View();
        }
    }
}