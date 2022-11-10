using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AlleClimb.Data;

/* This is used if database provider does't define
 * IAlleClimbDbSchemaMigrator implementation.
 */
public class NullAlleClimbDbSchemaMigrator : IAlleClimbDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
