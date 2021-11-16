using ControleFinanceiro.Core.Data;
using ControleFinanciero.Domain;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.Data.Repositories
{
    public class SaldoRepository : Repository<Saldo>, ISaldoRepository
    {
        public SaldoRepository(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
