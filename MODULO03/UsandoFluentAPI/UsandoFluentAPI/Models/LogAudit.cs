using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsandoFluentAPI.Models
{
    public class LogAudit
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime ModificadaEm { get; set; }
    }
}
