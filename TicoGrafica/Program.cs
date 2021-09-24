using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Windows.Forms;
using TicoGrafica.Forms.Forms.Pessoas;
using TicoGrafica.Infrastructure;
using TicoGrafica.Infrastructure.Repositories;
using TicoGrafica.Model.Modelos.IRepositories;
using TicoGrafica.Services.Services;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            ConfigurandoBancoDeDados(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form_TelaInicial>();
                Application.Run(form1);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IPessoaService, PessoaService>()
                    .AddScoped<IPessoaRepository, PessoaRepository>();

            services.AddScoped<IContasPagarService, ContasPagarService>()
                    .AddScoped<IContasPagarRepository, ContasPagarRepository>();

            services.AddScoped<IContasReceberService, ContasReceberService>()
                    .AddScoped<IContasReceberRepository, ContasReceberRepository>();

            services.AddScoped<IProdutoService, ProdutoService>()
                    .AddScoped<IProdutoRepository, ProdutoRepository>();

            services.AddScoped<IOrcamentoService, OrcamentoService>()
                    .AddScoped<IOrcamentoRepository, OrcamentoRepository>();

            var configuration = new ConfigurationBuilder()
                   .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                   .AddXmlFile("App.config")
                   .Build();

            string connectionString;
            configuration
                .Providers
                .FirstOrDefault()
                .TryGet("connectionStrings:add:ConnectionString:connectionString", out connectionString);

            services.AddDbContext<TicoGraficaContext>(options =>
                options.UseSqlite(connectionString)
            );

            services.AddScoped<Form_TelaInicial>();
            //services.AddScoped<Form_Cadastrar_Pessoa>();
            //services.AddScoped<Form_TelaInicial_Pessoas>();
        }

        private static void ConfigurandoBancoDeDados(ServiceCollection serviceCollection)
        {
            try
            {
                using (ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider())
                {
                    var dbContext = serviceProvider.GetService<TicoGraficaContext>();
                    dbContext.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
