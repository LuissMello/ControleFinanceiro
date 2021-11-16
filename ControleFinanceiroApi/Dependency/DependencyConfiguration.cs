using ControleFinanceiro.Core.Data;
using ControleFinanceiro.Core.Services;
using ControleFinanceiro.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiro.Api.Dependency
{
    public static class DependencyConfiguration
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<ISaldoService, SaldoService>();
            services.AddScoped<ITransacaoService, TransacaoService>();

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<ILocalRepository, LocalRepository>();
            services.AddScoped<ISaldoRepository, SaldoRepository>();
            services.AddScoped<ITransacaoRepository, TransacaoRepository>();
        }
    }
}
