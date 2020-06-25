using AspnCore_ViewInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnCore_ViewInjection.Services
{
    public class EstadosService
    {
        public List<Estado> GetEstados()
        {
            return new List<Estado>()
            {
                new Estado("São Paulo","SP"),
                new Estado("Rio de janeiro","RJ"),
                new Estado("Minas gerais","MG"),
                new Estado("Parana","PR")
            };
        }
    }
}
