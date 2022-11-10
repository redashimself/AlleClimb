using Volo.Abp.Modularity;

namespace AlleClimb;

[DependsOn(
    typeof(AlleClimbApplicationModule),
    typeof(AlleClimbDomainTestModule)
    )]
public class AlleClimbApplicationTestModule : AbpModule
{

}
