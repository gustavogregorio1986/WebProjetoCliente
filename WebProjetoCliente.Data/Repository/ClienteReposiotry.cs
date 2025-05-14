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
    public class ClienteReposiotry
    {
        private readonly DapperContext _context;

        public ClienteReposiotry(DapperContext context)
        {
            _context = context;
        }

        public async Task<int> AddClienteAsync(Cliente cliente)
        {
            var query = @"INSERT INTO Cliente(@NomeCliente, EmailCliente, Cpf)
                        VALUES(@NomeCliente, @EmailCliente, @Cpf, @ProdutoId);
                        SELECT CAST(SCOPE_IDENTITY() as int);";

            using var connection = _context.CreateConnection();

            var parameters = new
            {
                cliente.NomeCliente,
                cliente.EmailCliente,
                cliente.Cpf,
                cliente.ProdutoId
            };

            var id = await connection.ExecuteScalarAsync<int>(query, parameters);
            return id;
        }
    }
}
