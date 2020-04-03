using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Enchentes.UI.Models
{
    public class CidadeViewModel
    {
        public string Nome { get; set; }
        public string Uf { get; set; }
        public DateTime Atualizacao { get; set; }
        public PrevisaoViewModel Previsao { get; set; }
    }
}