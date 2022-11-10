using AlleClimb.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AlleClimb.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AlleClimbEntityFrameworkCoreModule),
    typeof(AlleClimbApplicationContractsModule)
    )]
public class AlleClimbDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
