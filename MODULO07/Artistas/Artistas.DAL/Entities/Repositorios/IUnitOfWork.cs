using System;
using System.Collections.Generic;
using System.Text;

namespace Artistas.DAL.Entities.Repositorios
{
    public interface IUnitOfWork : IDisposable
    {
        IArtistaRepository Artistas { get; }
        IArtistaDetalheRepository ArtistaDetalhes { get; }
        int Commit();
    }
}
