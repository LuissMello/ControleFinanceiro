using ControleFinanciero.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.Core.Services
{
    public interface IUsuarioService
    {
        Task<Usuario> CadastrarAsync(Usuario usuario);
        Task<bool> ValidarLoginAsync(string login, string senha);
    }
}
