using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;

namespace Enchentes.UI.Controllers
{
    public class CidadesController : Controller
    {
        // GET: Cidades
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PrevisaoCidade()
        {

            XmlDocument doc = new XmlDocument();
            string cadastro = "http://servicos.cptec.inpe.br/XML/cidade/7dias/4748/previsao.xml";
            doc.Load(cadastro);
            XmlNodeList previsao = doc.GetElementsByTagName("previsao");
            //TODO -- Deserializar xml em objeto !

            return View("Index");
        }
    }
}