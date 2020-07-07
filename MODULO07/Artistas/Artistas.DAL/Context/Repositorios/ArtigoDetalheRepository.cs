using Artistas.DAL.Entities;
using Artistas.DAL.Entities.Repositorios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Artistas.DAL.Context.Repositorios
{
    public class ArtistaDetalheRepository : Repository<ArtistaDetalhe>, IArtistaDetalheRepository
    {
        public ArtistaDetalheRepository(ArtistaContext context) : base(context)
        {
        }

        public IEnumerable<ArtistaDetalhe> GetDetalhesComArtistas(int pageIndex, int pageSize)
        {
            return ArtistaContext.ArtistaDetalhes
                .Include(c => c.Artista)
                .OrderBy(c => c.Talento)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public ArtistaContext ArtistaContext
        {
            get { return Context as ArtistaContext; }
        }
    }
}
