using ProjetoTCC.Models.Siglas;
using System.Collections.Generic;

namespace ProjetoTCC.Repositories
{
    public interface ICondicaoDoTempoRepository
    {
        void SaveProdutos(List<Condicao> livros);

        IList<CondicaoDoTempo> GetCondicaoDoTempo();
    }
}