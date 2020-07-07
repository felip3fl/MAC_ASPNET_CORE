using System;
using System.Collections.Generic;

namespace Artistas.DAL.Entities
{
    public class Artista
    {
        public int ArtistaId { get; set; }
        public string Nome { get; set; }
        public string Pais { get; set; }
        public string Cidade { get; set; }
        public string Site { get; set; }
        public DateTime Nascimento { get; set; }
        public virtual IList<ArtistaDetalhe> ArtistaDetalhes { get; set; }
    }
}
