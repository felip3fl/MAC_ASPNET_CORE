using System.Collections.Generic;
using vscode_vinject.Models;

namespace vscode_vinject.Services
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