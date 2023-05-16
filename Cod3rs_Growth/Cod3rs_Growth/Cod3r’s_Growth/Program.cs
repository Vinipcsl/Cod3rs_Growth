using System;
using System.Linq;
using System.Configuration;
using System.Windows.Forms;

using FluentMigrator.Runner;


using Microsoft.Extensions.DependencyInjection;

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

            ApplicationConfiguration.Initialize();
            Application.Run(new ListaCelular());
        }

        private static ServiceProvider CreateServices()
        {
            return new ServiceCollection()
                
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                .AddSQLite()
                .WithGlobalConnectionString("Data Source=test.db")
                .ScanIn(typeof(AddLogTable).Assembly).For.Migrations())
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