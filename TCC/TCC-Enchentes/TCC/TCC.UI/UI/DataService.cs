using ProjetoTCC.Models;
using ProjetoTCC.Repositories;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using ProjetoTCC.Models.Siglas;

namespace ProjetoTCC
{
    public class DataService : IDataService
    {
        private readonly ApplicationContext contexto;
        private readonly ICondicaoDoTempoRepository condicaoDoTempoRepository;

        public DataService(ApplicationContext contexto, ICondicaoDoTempoRepository condicaoDoTempoRepository)
        {
            this.contexto = contexto;
            this.condicaoDoTempoRepository = condicaoDoTempoRepository;
        }

        public void InicializarDB()
        {
            contexto.Database.Migrate();

            List<Condicao> condicoes = GetCondicao();

            condicaoDoTempoRepository.SaveProdutos(condicoes);

        }



        private static List<Condicao> GetCondicao()
        {
            var json = File.ReadAllText("condicoes.json");
            var condicoes = JsonConvert.DeserializeObject<List<Condicao>>(json);
            return condicoes;
        }
    }
    public class Condicao
    {
        public string Sigla { get; set; }
        public string Descricao { get; set; }
    }



}
