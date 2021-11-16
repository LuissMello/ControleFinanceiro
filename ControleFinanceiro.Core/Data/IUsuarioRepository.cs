﻿using ControleFinanciero.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Core.Data
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Task<Usuario> FindByLoginAsync(string login);
    }
}
