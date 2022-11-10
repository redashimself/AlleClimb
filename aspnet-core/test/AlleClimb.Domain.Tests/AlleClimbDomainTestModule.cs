using AlleClimb.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AlleClimb;

[DependsOn(
    typeof(AlleClimbEntityFrameworkCoreTestModule)
    )]
public class AlleClimbDomainTestModule : AbpModule
{

}
