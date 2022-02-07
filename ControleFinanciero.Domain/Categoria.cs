using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanciero.Domain
{
    public class Categoria : Subcategoria
    {
        public Guid IdUsuario { get; set; }
        public double Valor { get; set; }
    }
}
