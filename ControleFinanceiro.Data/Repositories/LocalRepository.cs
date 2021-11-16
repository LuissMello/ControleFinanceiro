using ControleFinanceiro.Core.Data;
using ControleFinanciero.Domain;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.Data.Repositories
{
    public class LocalRepository : Repository<Local>, ILocalRepository
    {
        public LocalRepository(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
