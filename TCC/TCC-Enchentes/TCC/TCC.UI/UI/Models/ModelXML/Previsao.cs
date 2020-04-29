using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjetoTCC.Models.ModelXML
{
    [Serializable]
    [XmlRoot(ElementName = "previsao")]
    public class Previsao
    {
        [XmlElement(ElementName = "dia")]
        public string dia { get; set; }

        [XmlElement(ElementName = "tempo")]
        public string tempo { get; set; }

        [XmlElement(ElementName = "maxima")]
        public string maxima { get; set; }

        [XmlElement(ElementName = "minima")]
        public string minima { get; set; }

        [XmlElement(ElementName = "iuv")]
        public string iuv { get; set; }
    }
}
