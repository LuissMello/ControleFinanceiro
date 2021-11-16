using ControleFinanceiro.Core.Data;
using ControleFinanciero.Domain;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiro.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly IConfiguration _configuration;
        protected readonly string _connectionString;

        public Repository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetSection("ConnectionStrings").GetValue<string>("DefaultConnection");
        }

        public async ValueTask<bool> DeleteAsync(TEntity model)
        {
            using var conexao = new SqlConnection(_connectionString);

            return await conexao.DeleteAsync(model);
        }

        public async ValueTask<TEntity> FindByIdAsync(Guid id)
        {
            using var conexao = new SqlConnection(_connectionString);

            return await conexao.GetAsync<TEntity>(id);
        }

        public async ValueTask<TEntity> InsertAsync(TEntity model)
        {
            using var conexao = new SqlConnection(_connectionString);

            await conexao.InsertAsync(model);

            return model;

        }

        public IQueryable<TEntity> QueryAsync()
        {
            throw new NotImplementedException();
        }

        public async ValueTask<bool> UpdateAsync(TEntity model)
        {
            using var conexao = new SqlConnection(_connectionString);

            return await conexao.UpdateAsync(model);
        }
    }
}
