using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanciero.Domain
{
    public class Transacao : Entity
    {
        public Guid IdUsuario { get; set; }
        public TipoTransacao TipoTransacao { get; set; }
        public decimal Valor { get; set; }
        public Guid? IdCategoria { get; set; }
        public string Descricao { get; set; }
        public Guid? IdLocal { get; set; }
        public DateTime Data { get; set; }
    }
}
