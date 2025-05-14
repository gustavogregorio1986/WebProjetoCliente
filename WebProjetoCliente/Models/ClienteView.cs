using System.ComponentModel.DataAnnotations;
using WebProjetoCliente.Dominio.Dominio;

namespace WebProjetoCliente.Models
{
    public class ClienteView
    {
        public Guid Id { get; set; }

        [Display(Name = "Nome do Cliente")]
        public string? NomeCliente { get; set; }

        public string? EmailCliente { get; set; }

        public string? Cpf { get; set; }

        public Guid ProdutoId { get; set; }

        public ProdutoView ProdutoView { get; set; }

        public ClienteView()
        {

        }

        public ClienteView(string? NomeCliente, string? EmailCliente, string? Cpf)
        {
            this.NomeCliente = NomeCliente;
            this.EmailCliente = EmailCliente;
            this.Cpf = Cpf;
        }

        public override string ToString()
        {
            return NomeCliente + "," + EmailCliente + "," + Cpf;
        }
    }
}
