using Artistas.DAL.Entities;
using Artistas.DAL.Entities.Repositorios;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Artistas.DAL.Context.Repositorios
{
    public class ArtistaRepository : Repository<Artista>, IArtistaRepository
    {
        public ArtistaRepository(ArtistaContext context) : base(context)
        {
        }

        public Artista getArtistaComDetalhes(int? id)
        {
            return ArtistaContext.Artistas.Include(a => a.ArtistaDetalhes)
                .SingleOrDefault(a => a.ArtistaId == id);
        }

        public ArtistaContext ArtistaContext
        {
            get { return Context as ArtistaContext; }
        }
    }
}
