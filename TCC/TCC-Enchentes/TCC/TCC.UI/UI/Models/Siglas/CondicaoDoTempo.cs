using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ProjetoTCC.Models.Siglas
{
    public class CondicaoDoTempo : BaseModel
    {

        public CondicaoDoTempo()
        {
        }
        [Required]
        public string Sigla { get; set; } = "";
        [Required]
        public string Descricao { get; set; } = "";

        public CondicaoDoTempo(string sigla, string descricao)
        {
            this.Sigla = sigla;
            this.Descricao = descricao;
        }


    }
}
