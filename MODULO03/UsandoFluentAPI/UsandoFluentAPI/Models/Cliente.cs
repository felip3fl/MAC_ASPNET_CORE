using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsandoFluentAPI.Models
{
    public class Cliente
    {
        public Cliente()
        {
            Pedidos = new List<Pedido>();
        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }

        public virtual List<Pedido> Pedidos { get; set; }
    }
}
