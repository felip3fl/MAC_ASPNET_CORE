using Artistas.DAL.Entities.Repositorios;

namespace Artistas.DAL.Context.Repositorios
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ArtistaContext _context;

        public UnitOfWork(ArtistaContext context)
        {
            _context = context;
            ArtistaDetalhes = new ArtistaDetalheRepository(_context);
            Artistas = new ArtistaRepository(_context);
        }

        public IArtistaRepository Artistas { get; private set; }
        public IArtistaDetalheRepository ArtistaDetalhes { get; private set; }


        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
