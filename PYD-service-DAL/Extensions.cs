using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using PYD_service_DAL.LinqToDb;
using PYD_service_DAL.Repositories;
using PYD_service_DAL.Repositories.Interfaces;

namespace PYD_service_DAL;

public static class Extensions
{
    public static IServiceCollection AddDal(this IServiceCollection services)
    {
        services.AddSingleton<ApplicationDbContext>();
        services.AddSingleton<IPYDRepository, PYDRepository>();
        
        services.AddFluentMigratorCore()
            .ConfigureRunner(rb => rb.AddPostgres()
                .WithGlobalConnectionString(s =>
                    "User ID=postgres;Password=123456;Host=localhost;Port=15432;Database=pyd-server;Pooling=true;")
                .ScanIn(typeof(Extensions).Assembly).For.Migrations()
            )
            .AddLogging(lb => lb.AddFluentMigratorConsole());

        return services;
    }
}