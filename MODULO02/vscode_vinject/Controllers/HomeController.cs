using Microsoft.AspNetCore.Mvc;

namespace vscode_vinject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}