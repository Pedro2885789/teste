using DOMINIO;
using FluentMigrator.Runner;
using INFRA;
using INFRA.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;

namespace CRUD
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {           
            var builder = CriaHostBuilder();
            var serviceProvider = builder.Build().Services;
            var scope = serviceProvider.CreateScope();
            UpdateDatabase(scope.ServiceProvider);           
            var repositorio = serviceProvider.GetService<IRepositorio>()
                ?? throw new Exception("Serviço repositório não encontrado");

            ApplicationConfiguration.Initialize();
            Application.Run(new ControleDePecas(repositorio));
        }

        private static void UpdateDatabase(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            runner.MigrateUp();
        }

        static IHostBuilder CriaHostBuilder()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;

            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddScoped<IRepositorio, RepositorioLinq2Db>();
                    services.AddFluentMigratorCore()
                        .ConfigureRunner(rb => rb
                                .AddSqlServer()
                                .WithGlobalConnectionString(connectionString)
                                .ScanIn(typeof(AdicionarTabelaPecas).Assembly).For.Migrations())
                            .AddLogging(lb => lb.AddFluentMigratorConsole())
                            .BuildServiceProvider(false);
                });
        }
    }
}
