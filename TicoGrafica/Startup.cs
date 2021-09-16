using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using TicoGrafica.Infrastructure;
using Microsoft.Extensions.Hosting;

namespace TicoGrafica
{
    public class Startup
    {
        IConfigurationRoot Configuration { get; }
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(env.ContentRootPath)
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
               .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
               .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConfigurationRoot>(Configuration);

            var connection = Configuration["ConexaoSqlite:SqliteConnectionString"];

            services.AddDbContext<TicoGraficaContext>(options =>
                options.UseSqlite(connection)
            );
        }
    }
}
