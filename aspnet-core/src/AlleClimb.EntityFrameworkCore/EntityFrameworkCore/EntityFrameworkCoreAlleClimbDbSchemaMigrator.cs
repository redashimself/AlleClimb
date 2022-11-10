using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AlleClimb.Data;
using Volo.Abp.DependencyInjection;

namespace AlleClimb.EntityFrameworkCore;

public class EntityFrameworkCoreAlleClimbDbSchemaMigrator
    : IAlleClimbDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAlleClimbDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AlleClimbDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AlleClimbDbContext>()
            .Database
            .MigrateAsync();
    }
}
