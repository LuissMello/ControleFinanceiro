using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanciero.Domain
{
    public class Categoria : Entity
    {
        public Guid IdUsuario { get; set; }
        public string Descricao { get; set; }
    }
}
