using ControleEstoque.Core.Data;
using ControleFinanciero.Domain;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEstoque.Data.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
