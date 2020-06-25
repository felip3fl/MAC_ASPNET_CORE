using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcAreas.Areas.Produtos.Models;

namespace MvcAreas.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            var produtos = ProdutoService.GetListaProdutos();
            return View(produtos);
        }
    }
}
