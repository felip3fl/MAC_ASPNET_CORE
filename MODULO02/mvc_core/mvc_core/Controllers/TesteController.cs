using System;
using Microsoft.AspNetCore.Mvc;

namespace mvc_core.Controllers
{
    [Route("[controller]/[action]")]
    public class TesteController: Controller
    {
        public IActionResult Index()
        {
            ViewData["Saudacao"] = "Olá........";
            ViewData["DataInicio"] = new DateTime(2019,09,01);
            ViewData["Endereco"] = new Endereco()
            {
                Nome="Felipe",
                Rua="Rua teste",
                Cidade="São pauilçpo",
                Estado = "SP"
            };

            return View();
        }

        public IActionResult IndexViewBag()
        {
            ViewData["Saudacao"] = "Olá........";
            ViewData["DataInicio"] = new DateTime(2019,09,01);
            ViewData["Endereco"] = new Endereco()
            {
                Nome="Felipe",
                Rua="Rua teste",
                Cidade="São pauilçpo",
                Estado = "SP"
            };

            return View();
        }

    }
}