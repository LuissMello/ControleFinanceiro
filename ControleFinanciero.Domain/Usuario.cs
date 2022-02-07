using NetDevPack.Domain;
using System;

namespace ControleFinanciero.Domain
{
    public class Usuario : Subcategoria
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
