namespace Artistas.DAL.Entities.Repositorios
{
    public interface IArtistaRepository : IRepository<Artista>
    {
        Artista getArtistaComDetalhes(int? id);
    }
}
