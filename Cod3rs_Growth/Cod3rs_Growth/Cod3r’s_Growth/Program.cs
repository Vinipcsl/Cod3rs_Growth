using System;
using System.Linq;
using System.Configuration;
using System.Windows.Forms;

using FluentMigrator.Runner;


using Microsoft.Extensions.DependencyInjection;
using Cod3r_s_Growth.Banco;
using Cod3r_s_Growth.Repositorio;

namespace Cod3r_s_Growth
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var builder = CriaHostBuilder();
            var servicesProvider = builder.Build().Services;
            var repositorio = servicesProvider.GetService<IRepositorio>();


            using (var serviceProvider = CreateServices())
            using (var scope = serviceProvider.CreateScope())
            {
                UpdateDatabase(scope.ServiceProvider);
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new ListaCelular());
        }

        static string CadastroCelular = ConfigurationManager.ConnectionStrings["CodersGrowth"].ConnectionString;


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
    }
}