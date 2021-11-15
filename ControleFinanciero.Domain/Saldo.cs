using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanciero.Domain
{
    public class Saldo : Entity
    {
        public Guid IdUsuario { get; set; }
        public double ValorSaldo { get; set; }
    }
}
