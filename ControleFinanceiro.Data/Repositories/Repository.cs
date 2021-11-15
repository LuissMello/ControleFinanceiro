using ControleFinanceiro.Core.Data;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using NetDevPack.Domain;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiro.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly IConfiguration _configuration;
        private readonly string connectionString;

        public Repository(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetSection("ConnectionStrings").GetValue<string>("DefaultConnection");
        }

        public async ValueTask<bool> DeleteAsync(TEntity model)
        {
            using var conexao = new SqlConnection(connectionString);

            return await conexao.DeleteAsync(model);
        }

        public async ValueTask<TEntity> FindByIdAsync(Guid id)
        {
            using var conexao = new SqlConnection(connectionString);

            return await conexao.GetAsync<TEntity>(id);
        }

        public async ValueTask<TEntity> InsertAsync(TEntity model)
        {
            using var conexao = new SqlConnection(connectionString);

            await conexao.InsertAsync(model);

            return model;

        }

        public IQueryable<TEntity> QueryAsync()
        {
            throw new NotImplementedException();
        }

        public async ValueTask<bool> UpdateAsync(TEntity model)
        {
            using var conexao = new SqlConnection(connectionString);

            return await conexao.UpdateAsync(model);
        }
    }
}
