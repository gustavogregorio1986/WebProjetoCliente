using Microsoft.AspNetCore.Mvc;
using WebProjetoCliente.Data.Repository;
using WebProjetoCliente.Dominio.Dominio;
using WebProjetoCliente.Models;

namespace WebProjetoCliente.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteReposiotry _clienteReposiotry;
        private readonly ProdutoRepository _produtoRepository;

        public ClienteController(ClienteReposiotry clienteReposiotry, ProdutoRepository produtoRepository)
        {
            _clienteReposiotry = clienteReposiotry;
            _produtoRepository = produtoRepository;
        }

        public IActionResult CadastrarCliente()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarCliente(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                // Converte para ClienteView antes de enviar para a View
                return View(new ClienteView
                {
                    NomeCliente = cliente.NomeCliente,
                    EmailCliente = cliente.EmailCliente,
                    Cpf = cliente.Cpf,
                    ProdutoId = cliente.ProdutoId
                });
            }

            try
            {
                await _clienteReposiotry.AddClienteAsync(cliente);
                TempData["MensagemSucesso"] = "Cliente cadastrado com sucesso!";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                ModelState.AddModelError("", "Erro ao cadastrar o cliente.");

                // Também converte no caso de erro
                return View(new ClienteView
                {
                    NomeCliente = cliente.NomeCliente,
                    EmailCliente = cliente.EmailCliente,
                    Cpf = cliente.Cpf,
                    ProdutoId = cliente.ProdutoId
                });
            }
        }


        [HttpPost]
        public async Task<IActionResult> CadastrarProduto(Produto produto)
        {
            if (!ModelState.IsValid)
            {
                return View(produto); // Retorna os erros de validação
            }

            try
            {
                await _produtoRepository.AddProdutoAsync(produto);
                TempData["MensagemSucesso"] = "Produto cadastrado com sucesso!";
                return RedirectToAction("Index"); // ou a lista de produtos
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                ModelState.AddModelError("", "Erro ao cadastrar o produto.");
                return View(produto);
            }
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
