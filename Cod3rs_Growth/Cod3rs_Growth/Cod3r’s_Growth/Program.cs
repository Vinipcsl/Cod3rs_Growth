using System.Configuration;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Cod3r_s_Growth.Dominio.Repositorio;
using Cod3r_s_Growth.Infra.Banco;
using Cod3r_s_Growth.Infra.RepositorioBanco;
using Cod3r_s_Growth.Infra;

namespace Cod3r_s_Growth
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var serviceProvider = CreateServices())
            using (var scope = serviceProvider.CreateScope())
            {
                UpdateDatabase(scope.ServiceProvider);
            }

            var builderBancoDados = CriarHostBuilder();
            var servicesProvider = builderBancoDados.Build().Services;
            var repositorio = servicesProvider.GetService<IRepositorio>();

            ApplicationConfiguration.Initialize();
            Application.Run(new ListaCelular(repositorio));
        }

        private static ServiceProvider CreateServices()
        {
            return new ServiceCollection()

                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                .AddSqlServer2016()
                .WithGlobalConnectionString("Data Source=INVENT023;Initial Catalog=CodersGrowth;User ID=sa;Password=sap@123")
                .ScanIn(typeof(Conexão).Assembly).For.Migrations())
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                .BuildServiceProvider(false);
        }

        private static void UpdateDatabase(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();

            runner.MigrateUp();
        }

        static IHostBuilder CriarHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddScoped<IRepositorio, Linq2DB>();
                });
        }
    }
}