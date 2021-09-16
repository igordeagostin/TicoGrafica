using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TicoGrafica.Infrastructure;

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

            Application.Run(new Form1());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            //services.AddScoped<IBusinessLayer, CBusinessLayer>()
            //        .AddScoped<IBusinessLayer, CBusinessLayer>()
            //        .AddSingleton<IDataAccessLayer, CDataAccessLayer>();

            var connection = "Data Source=TicoGrafica.db";

            services.AddDbContext<TicoGraficaContext>(options =>
                options.UseSqlite(connection)
            );
        }
    }
}
