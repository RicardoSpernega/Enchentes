using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjetoTCC.Models.ModelXML
{

    [Serializable]
    [XmlRoot(ElementName = "cidade")]
    public class Cidades
    {
        [XmlElement(ElementName = "nome")]
        public string nome { get; set; }

        [XmlElement(ElementName = "uf")]
        public string uf { get; set; }

        [XmlElement(ElementName = "atualizacao")]
        public DateTime atualizacao { get; set; }

        [XmlElement(ElementName = "previsao")]
        public List<Previsao> previsao { get; set; }
    }
}
