using Microsoft.AspNetCore.Mvc;

namespace WebApp_Tarde.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Lista()
        {
            return View();
        }
    }
}
