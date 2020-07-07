using System;
using System.Collections.Generic;
using System.Text;

namespace Artistas.DAL.Entities.Repositorios
{
    public interface IArtistaDetalheRepository : IRepository<ArtistaDetalhe>
    {
        IEnumerable<ArtistaDetalhe> GetDetalhesComArtistas(int pageIndex, int pageSize);
    }
}
