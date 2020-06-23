using Microsoft.AspNetCore.Mvc;

namespace mvc_core.Controllers
{
    public class ProdutoController : Controller
    {
        public string Index()
        {
            var https = HttpContext.Request.IsHttps;
            var caminho  = HttpContext.Request.Path;
            var status  = HttpContext.Response.StatusCode;
            var conexao  = HttpContext.Connection.ToString();

            return https + "\r\n" + caminho + "\r\n" + status + "\r\n" + conexao;
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
    }
}
