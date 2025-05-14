using Microsoft.AspNetCore.Mvc;

namespace WebProjetoCliente.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult CadastrarCliente()
        {
            return View();
        }

        public IActionResult CadastrarProduto()
        {
            return View();
        }

        public IActionResult ConsultarCliente()
        {
            return View();
        }

        public IActionResult ConsultarProduto()
        {
            return View();
        }
    }
}
