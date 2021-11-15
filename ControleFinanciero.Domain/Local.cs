using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanciero.Domain
{
    public class Local : Entity
    {
        public Guid Idusuario { get; set; }
        public string Descricao { get; set; }
    }
}
