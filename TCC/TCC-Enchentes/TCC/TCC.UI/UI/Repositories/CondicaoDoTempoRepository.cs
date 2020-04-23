using ProjetoTCC.Models.Siglas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Repositories
{
    public class CondicaoDoTempoRepository : BaseRepository<CondicaoDoTempo>, ICondicaoDoTempoRepository
    {
        public CondicaoDoTempoRepository(ApplicationContext contexto) : base(contexto)
        {
        }
        public IList<CondicaoDoTempo> GetCondicaoDoTempo()
        {
            return dbSet.ToList();
        }

        public void SaveProdutos(List<Condicao> condicoes)
        {

            foreach (var condicao in condicoes)
            {
                if (!dbSet.Where(p => p.Sigla == condicao.Sigla).Any())
                {
                    dbSet.Add(new CondicaoDoTempo(condicao.Sigla, condicao.Descricao));
                }

            }

            contexto.SaveChanges();
        }
    }
}
