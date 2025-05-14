using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjetoCliente.Dominio.Dominio
{
    public class Cliente
    {
        public Guid Id { get; set; }

        public string? NomeCliente { get; set; }

        public string? EmailCliente { get; set; }

        public string? Cpf { get; set; }

        public Guid ProdutoId { get; set; }

        public Produto Produto { get; set; }

        public Cliente()
        {
            
        }

        public Cliente(string? NomeCliente, string? EmailCliente, string? Cpf)
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
