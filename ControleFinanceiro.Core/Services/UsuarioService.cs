using ControleFinanceiro.Core.Data;
using ControleFinanciero.Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Core.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly ILogger<UsuarioService> _logger;
        private readonly IConfiguration _configuration;
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(ILogger<UsuarioService> logger, IConfiguration configuration, IUsuarioRepository usuarioRepository)
        {
            _logger = logger;
            _configuration = configuration;
            _usuarioRepository = usuarioRepository;
        }


        public async Task<Usuario> CadastrarAsync(Usuario usuario)
        {
            try
            {
                return await _usuarioRepository.InsertAsync(usuario);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> ValidarLoginAsync(string login, string senha)
        {
            var usuario = await _usuarioRepository.FindByLoginAsync(login)
                ?? throw new Exception("Usuário não encontrado");

            return usuario.Senha == senha;
        }
    }
}
