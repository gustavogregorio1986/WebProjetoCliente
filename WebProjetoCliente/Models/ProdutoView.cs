using System.ComponentModel.DataAnnotations;
using WebProjetoCliente.Dominio.Dominio;

namespace WebProjetoCliente.Models
{
    public class ProdutoView
    {
        public Guid Id { get; set; }

        [Display(Name = "Nome do Produto")]
        public string? NomeProduto { get; set; }

        public string? Descricao { get; set; }

        public decimal Preco { get; set; }

        public int Quantidade { get; set; }

        public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

        public ProdutoView()
        {

        }

        public ProdutoView(string? NomeProduto, string? Descricao, decimal Preco, int Quantidade)
        {
            this.NomeProduto = NomeProduto;
            this.Descricao = Descricao;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }
    }
}
