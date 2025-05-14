using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjetoCliente.Dominio.Dominio
{
    public class Produto
    {
        public Guid Id { get; set; }

        public string? NomeProduto { get; set; }

        public string? Descricao { get; set; }

        public decimal Preco { get; set; }

        public int Quantidade { get; set; }

        public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

        public Produto()
        {
            
        }

        public Produto(string? NomeProduto, string? Descricao, decimal Preco, int Quantidade)
        {
            this.NomeProduto = NomeProduto;
            this.Descricao = Descricao;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }
    }
}
