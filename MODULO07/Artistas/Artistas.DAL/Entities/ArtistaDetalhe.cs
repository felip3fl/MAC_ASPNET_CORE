using System;
using System.Collections.Generic;
using System.Text;

namespace Artistas.DAL.Entities
{
    public class ArtistaDetalhe
    {
        public int ArtistaDetalheId { get; set; }
        public string Talento { get; set; }
        public string Detalhes { get; set; }
        public virtual Artista Artista { get; set; }
    }
}
