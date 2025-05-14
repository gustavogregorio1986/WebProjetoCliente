using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjetoCliente.Data.Dapper;
using WebProjetoCliente.Dominio.Dominio;

namespace WebProjetoCliente.Data.Repository
{
    public class ProdutoRepository
    {
        private readonly DapperContext _context;

        public ProdutoRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<int> AddProdutoAsync(Produto produto)
        {
            var query = @"INSERT INTO Produto (NomeProduto, Descricao, Preco, Quantidade)
                  VALUES (@NomeProduto, @Descricao, @Preco, @Quantidade);
                  SELECT CAST(SCOPE_IDENTITY() as int);";

            using var connection = _context.CreateConnection();

            var parameters = new
            {
                produto.NomeProduto,
                produto.Descricao,
                produto.Preco,
                produto.Quantidade
            };

            var id = await connection.ExecuteScalarAsync<int>(query, parameters);
            return id;
        }

    }
}
