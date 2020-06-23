using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using mvc_core.Models;
using mvc_core.ViewModels;

namespace mvc_core.Controllers
{
    [Route("[controller]/[action]")]
    public class ClientesController : Controller
    {
        public IActionResult Detalhe()
        {
            Cliente cliente = new Cliente
            {
                ClienteId = 100,
                Nome = "Felipe",
                Email = "felipe@gmail.com"
            };

            var pedidos = new List<Pedido>
            {
                new Pedido{Nome = "Pedido 1"},
                new Pedido{Nome = "Pedido 2"}
            };

            var viewModel = new ClientePedidoViewModel
            {
                Cliente = cliente,
                Pedidos = pedidos
            };

            return View(viewModel);
        }
    }
}