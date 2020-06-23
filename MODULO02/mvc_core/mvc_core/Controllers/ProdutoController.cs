using Microsoft.AspNetCore.Mvc;

namespace mvc_core.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index(int? pagina, string ordem)
        {
            // var https = HttpContext.Request.IsHttps;
            // var caminho  = HttpContext.Request.Path;
            // var status  = HttpContext.Response.StatusCode;
            // var conexao  = HttpContext.Connection.ToString();
            // return https + "\r\n" + caminho + "\r\n" + status + "\r\n" + conexao;

            if(!pagina.HasValue)
                pagina=1;

            if(string.IsNullOrEmpty(ordem))
                ordem="Nome";

            return Content(string.Format("pagina={0}&ordem={1}", pagina, ordem));
        }

        public IActionResult Detalhe()
        {
            //return View();
            //return RedirectToAction("Index");
            //return RedirectToAction("Index","Home");
            // return RedirectToAction("Index","Home", new{pagina=1,ordem="nome"});
            //return Content("Uma string simples");
            //return Content("Arquivo PDF", "application/pdf");
            //return File("images/banner1.svg","image/svg+xml");
            // var pessoa = new {Id = 1, Nome = "Felipe"};
            // return new ObjectResult(pessoa);
            
            return View();
        }

        public IActionResult Edit(int codigo)
        {
            return Content("Valor do Id = " + codigo);
        }

        public IActionResult DataLancamento(int ano, int mes)
        {
            return Content(ano + "/" + mes);
        }
    }
}
