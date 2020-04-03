using Enchentes.UI.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Enchentes.UI.Models
{
    public class PrevisaoViewModel
    {
        public DateTime Dia { get; set; }
        public TempoEnum Tempo   { get; set; }
        public int Maxima { get; set; }
        public int Minima { get; set; }
        public float iuv { get; set; }
    }
}