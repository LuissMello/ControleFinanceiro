using ControleEstoque.Core.Services;
using ControleFinanciero.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace ControleEstoque.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(ILogger<UsuarioController> logger, IUsuarioService usuarioService)
        {
            _logger = logger;
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public async void Cadastrar(string login, string senha, string nome)
        {
            await _usuarioService.CadastrarAsync(new Usuario
            {
                Login = login,
                Nome = nome,
                Senha = senha
            });
        }

        [HttpPost]
        public async Task<bool> Login(string login, string senha)
        {
            var retorno =  await _usuarioService.ValidarLoginAsync(login, senha);

            return retorno;
        }
    }
}
