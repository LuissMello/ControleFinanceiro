using ControleFinanceiro.Core.Data;
using ControleFinanciero.Domain;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Data;

namespace ControleFinanceiro.Data.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public async Task<Usuario> FindByLoginAsync(string login)
        {
            using var conexao = new SqlConnection(_connectionString);

            var sql = "select * from usuarios where login = @login";

            var parameters = new DynamicParameters();
            parameters.Add(name: "@login", value: login, dbType: DbType.String, direction: ParameterDirection.Input);

            return await conexao.QuerySingleAsync<Usuario>(sql, parameters);
        }
    }
}
